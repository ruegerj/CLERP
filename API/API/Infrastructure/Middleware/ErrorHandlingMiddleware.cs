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
            object errors = null;

            // prepare response based on excpetion type / log exception base on type
            switch (exception)
            {
                case RestException re:
                    {
                        errors = re.Payload;
                        context.Response.StatusCode = (int)re.StatusCode;
                        break;
                    }
                case Exception ex:
                    {
                        errors = String.IsNullOrWhiteSpace(ex.Message) ? "Error" : ex.Message;
                        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                        logger.LogError("Caught excption, sending appropriate response...", ex);
                        break;
                    }
            }

            context.Response.ContentType = "application/json";

            var result = JsonConvert.SerializeObject(new
            {
                errors
            });

            await context.Response.WriteAsync(result); // Send response
        }        
    }
}
