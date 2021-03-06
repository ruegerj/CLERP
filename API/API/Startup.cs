﻿using AutoMapper;
using CLERP.API.Infrastructure.Behavior;
using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Conventions;
using CLERP.API.Infrastructure.Middleware;
using CLERP.API.Infrastructure.Policies.Authorization.IpCheck;
using CLERP.API.Infrastructure.Security.Hashing;
using CLERP.API.Infrastructure.Security.Tokens;
using CLERP.API.Infrastructure.Swagger;
using CLERP.API.Infrastructure.Utilities;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;

namespace CLERP.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            var currentAssembly = GetType().Assembly;

            // load custom settings
            var settingsSection = Configuration.GetSection(nameof(AppSettings));
            var settings = settingsSection.Get<AppSettings>();

            var jwtSection = Configuration.GetSection(nameof(JwtOptions));
            var jwtOptions = jwtSection.Get<JwtOptions>();

            services.Configure<AppSettings>(settingsSection);
            services.Configure<JwtOptions>(jwtSection);

            services.AddDbContext<ClerpContext>(options => options.UseSqlServer(settings.ConnectionstringLocal));

            var signInConfigurations = new SignInConfigurations();
            services.AddSingleton(signInConfigurations);

            // register custom authorization policies and handler
            services.AddSingleton<IAuthorizationHandler, IpCheckHandler>();
            services.AddAuthorization(options =>
            {
                options.AddPolicy("MatchingIpPolicy", policy => policy.Requirements.Add(new IpCheckRequirement()));
            });

            // configure jwt auth
            services.AddAuthentication(auth =>
            {
                auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(jwtBearerOptions =>
            {
                jwtBearerOptions.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateAudience = false,
                    ValidateIssuer = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = signInConfigurations.Key,
                    ClockSkew = TimeSpan.Zero,
                    RequireSignedTokens = true
                };

                jwtBearerOptions.RequireHttpsMetadata = true;
            });

            services.AddMvc(options =>
            {
                options.Conventions.Add(new GroupByApiRootConvention());

                // add auth policy globally so every reqest has to be authenticated, unless the controller is decorated with the "AllowAnonymous" attribute
                var authPolicy = new AuthorizationPolicyBuilder()
                    .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                    .RequireAuthenticatedUser()
                    .Build();
                options.Filters.Add(new AuthorizeFilter(authPolicy));

                // apply MatchingIpPolicy globally for all controllers, only if the current ip and the ip registered in the token match access will be granted
                options.Filters.Add(new AuthorizeFilter("MatchingIpPolicy"));
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

            services.AddApiVersioning(options =>
            {
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new ApiVersion(1, 0); // v1
                options.ReportApiVersions = true;
            });

            services.AddCors();

            services.AddHsts(options =>
            {
                options.Preload = true;
                options.IncludeSubDomains = true;
                options.MaxAge = TimeSpan.FromDays(settings.HSTSMaxAge);

            });

            services.AddHttpsRedirection(options =>
            {
                options.RedirectStatusCode = StatusCodes.Status307TemporaryRedirect;
                options.HttpsPort = 5001;
            });

            services.AddSwagger();

            // Register MediatR and custom behavior for pipeline
            services.AddMediatR(currentAssembly);
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(PerformanceProfilerPipelineBehaviour<,>));
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(DBContextTransactionPipelineBehavior<,>));

            // Add Automapper and scan assembly automatically for mapping profiles
            services.AddAutoMapper(currentAssembly);
            Mapper.Initialize(cfg => cfg.AddMaps(currentAssembly));

            services.Configure<ApiBehaviorOptions>(options => { options.SuppressModelStateInvalidFilter = true; }); // Disable built in validation error response

            services.AddScoped<IPasswordHasher, PasswordHasher>(); // Register hashing implentation for password hashing within the application
            services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddSingleton<ICurrentUserAccessor, CurrentUserAccessor>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                // Allow cors only while development
                app.UseCors(c => c
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod());
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCustomMiddleware();

            app.UseHttpsRedirection();
            app.UseMvc();

            app.UseAuthentication();

            app.UseSwaggerMiddleware();
        }
    }
}
