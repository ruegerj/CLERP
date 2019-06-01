using CLERP.API.Infrastructure.Swagger.Filter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Filters;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

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
            // Register all swagger examples
            services.AddSwaggerExamples();

            // Solution for swagger with asp.net core versioning:
            // https://stackoverflow.com/questions/40929916/how-to-set-up-swashbuckle-vs-microsoft-aspnetcore-mvc-versioning
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Info()
                {
                    Title = "CLERP API v1",
                    Description = "REST Web-Api-Backend for the CLERP application",
                    Version = "v1"
                });

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

                // Include XML-Comments in swagger doc
                options.IncludeXmlComments(xmlPath);

                // Enable swagger annotations
                options.EnableAnnotations();

                // Register jwt bearer authentication method
                options.AddSecurityDefinition("Bearer", new ApiKeyScheme()
                {
                    Description = "Please insert JWT with Bearer into field. Example: \"bearer {token}\"",
                    In = "header",
                    Name = "Authorization",
                    Type = "apiKey"
                });

                options.DescribeAllEnumsAsStrings();
                options.DescribeStringEnumsInCamelCase();

                // Add fluent validation rules to swagger documentation
                options.AddFluentValidationRules();

                // Register default responses for endpoints
                options.OperationFilter<DefaultResponsesFilter>();

                // Register default data format
                options.OperationFilter<DefaultDataFormatFilter>();

                // Adds "(Auth)" to the summary so that you can see which endpoints have Authorization
                options.OperationFilter<AppendAuthorizeToSummaryOperationFilter>();

                // add Security information to each operation for JWT Auth
                options.OperationFilter<SecurityRequirementsOperationFilter>();

                // This call remove version from parameter, without it we will have version as parameter 
                // for all endpoints in swagger UI
                options.OperationFilter<RemoveVersionFromParameterFilter>();

                // This make replacement of v{version:apiVersion} to real version of corresponding swagger doc.
                options.DocumentFilter<ReplaceVersionWithExactValueInPathFilter>();

                // This on used to exclude endpoint mapped to not specified in swagger version.
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
                config.SwaggerEndpoint("/swagger/v1/swagger.json", "CLERP API v1");
                config.RoutePrefix = string.Empty;
                config.DisplayOperationId();
            });

            return app;
        }
    }
}
