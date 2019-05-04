using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CLERP.API.Infrastructure.Security.Hashing;
using CLERP.API.Infrastructure.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MediatR;
using System.Reflection;
using AutoMapper;
using CLERP.API.Infrastructure.Conventions;
using Newtonsoft.Json;
using FluentValidation.AspNetCore;
using CLERP.API.Infrastructure.Errors;
using CLERP.API.Infrastructure.Behavior;
using CLERP.API.Infrastructure.Utilities;
using Microsoft.AspNetCore.Http;
using CLERP.API.Infrastructure.Middleware;

namespace CLERP.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var currentAssembly = GetType().Assembly;

            // load custom settings
            var settingsSection = Configuration.GetSection(nameof(Settings));
            var settings = settingsSection.Get<Settings>();

            services.Configure<Settings>(settingsSection);

            services.AddDbContext<ClerpContext>(options => options.UseSqlServer(settings.ConnectionStringLocal));

            services.AddMvc(options => 
            {
                options.Conventions.Add(new GroupByApiRootConvention());
            })
            .AddJsonOptions(options => 
            {
                options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
            })
            .AddFluentValidation(config => 
            {
                config.RegisterValidatorsFromAssemblyContaining<Startup>();
            })
            .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddApiVersioning();

            services.AddCors();

            // Register MediatR and custom behavior for pipeline
            services.AddMediatR(currentAssembly);
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehavior<,>));
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(DBContextTransactionPipelineBehavior<,>));

            services.AddAutoMapper(currentAssembly);

            services.Configure<ApiBehaviorOptions>(options => { options.SuppressModelStateInvalidFilter = true; } ); // Disable built in validation error response

            services.AddScoped<IPasswordHasher, Sha512Hasher>(); // Register hashing implentation for password hashing within the application
            services.AddScoped<ICurrentUserAccessor, CurrentUserAccessor>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCustomMiddleware();

            app.UseCors(c => c
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
