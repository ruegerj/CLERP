using CLERP.API.Infrastructure.Exceptions;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Middleware
{
    /// <summary>
    /// Middleware which handles error thrown in the app
    /// </summary>
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorHandlingMiddleware> _logger;

        public ErrorHandlingMiddleware(
            RequestDelegate next,
            ILogger<ErrorHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }


        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex, _logger);
            }
        }

        private static async Task HandleExceptionAsync(
            HttpContext context,
            Exception exception,
            ILogger<ErrorHandlingMiddleware> logger)
        {
            object responseContainer = default; // container for the response data

            // prepare response based on excpetion type / log exception base on type
            switch (exception)
            {
                case ConflictException ce:
                    {
                        responseContainer = ce.Payload;
                        context.Response.StatusCode = (int)ce.StatusCode;
                        break;
                    }
                case BadRequestException bre:
                    {
                        responseContainer = bre.Payload;
                        context.Response.StatusCode = (int)bre.StatusCode;
                        break;
                    }
                case Exception ex:
                    {
                        responseContainer = new Features.v1.MessageResponse(
                            "An unknown error occured"
                        );
                        
                        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                        logger.LogError($"Caught exception of type {ex.GetType()}, sending appropriate response...", ex);
                        break;
                    }
            }

            context.Response.ContentType = "application/json";

            var result = JsonConvert.SerializeObject(responseContainer);

            await context.Response.WriteAsync(result); // Write data in response body
        }        
    }
}
