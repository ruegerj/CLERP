using CLERP.API.Features.v1;
using CLERP.API.Infrastructure.Exceptions;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;

namespace CLERP.API.Infrastructure.Swagger.Filter
{
    /// <summary>
    /// Registers all default responses and their appearance and adds them globally for every endpoint in the swagger doc
    /// </summary>
    public class DefaultResponsesFilter : IOperationFilter
    {
        public void Apply(Operation operation, OperationFilterContext context)
        {
            // register validation failed response only if the endpoint has atleast one parameter
            if (context.MethodInfo.GetParameters().Any())
            {
                // Unprocessable Entity (422) - Failed Validation
                var validationFailedResponseSchema = context.SchemaRegistry.GetOrRegister(typeof(ValidationFailedResponse));
                operation.Responses.Add("422", new Response() { Description = "Validation failed", Schema = validationFailedResponseSchema });
            }

            // Internal Server Error (500)
            var internalSeverErrorResponseSchema = context.SchemaRegistry.GetOrRegister(typeof(MessageResponse));
            operation.Responses.Add("500", new Response() { Description = "An unknown error occured", Schema = internalSeverErrorResponseSchema });
        }
    }
}
