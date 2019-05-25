﻿using CLERP.API.Infrastructure.Swagger.Filter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Swagger
{
    /// <summary>
    /// Extensions for registering and configuring all swagger components
    /// </summary>
    public static class SwaggerExtension
    {
        /// <summary>
        /// Configures SwaggerGen
        /// </summary>
        /// <param name="services"></param>
        public static void AddSwagger(this IServiceCollection services)
        {
            // Solution for swagger with asp.net core versioning:
            // https://stackoverflow.com/questions/40929916/how-to-set-up-swashbuckle-vs-microsoft-aspnetcore-mvc-versioning
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Info()
                {
                    Title = "CLERP API",
                    Description = "REST Web-Api-Backend for the CLERP application",
                    Version = "v1"
                });

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

                options.IncludeXmlComments(xmlPath);

                // Add fluent validation rules to swagger documentation
                options.AddFluentValidationRules();

                // This call remove version from parameter, without it we will have version as parameter 
                // for all endpoints in swagger UI
                options.OperationFilter<RemoveVersionFromParameter>();

                // This make replacement of v{version:apiVersion} to real version of corresponding swagger doc.
                options.DocumentFilter<ReplaceVersionWithExactValueInPath>();

                // This on used to exclude endpoint mapped to not specified in swagger version.
                // In this particular example we exclude 'GET /api/v2/Values/otherget/three' endpoint,
                // because it was mapped to v3 with attribute: MapToApiVersion("3")
                options.DocInclusionPredicate((version, desc) =>
                {
                    if (!desc.TryGetMethodInfo(out MethodInfo methodInfo)) return false;

                    var versions = methodInfo.DeclaringType.GetConstructors().SelectMany(ci =>
                                    ci.DeclaringType.CustomAttributes.Where(cad =>
                                        cad.AttributeType == typeof(ApiVersionAttribute))
                                    .SelectMany(cad =>
                                        cad.ConstructorArguments.Select(cata =>
                                            cata.Value)));

                    var maps = methodInfo.DeclaringType.GetConstructors().SelectMany(ci =>
                                    ci.DeclaringType.CustomAttributes.Where(cad =>
                                        cad.AttributeType == typeof(MapToApiVersionAttribute))
                                    .SelectMany(cad =>
                                        cad.ConstructorArguments.Select(cata =>
                                            cata.Value))).ToArray();

                    return versions.Any(v => $"v{v.ToString()}" == version) && (maps.Length == 0 || maps.Any(v => $"v{v.ToString()}" == version));
                });
            });
        }

        /// <summary>
        /// Enables Swagger and SwaggerUI middleware
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseSwaggerMiddleware(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(config =>
            {
                config.SwaggerEndpoint("/swagger/v1/swagger.json", "CLERP API");
                config.RoutePrefix = string.Empty;
            });

            return app;
        }
    }
}
