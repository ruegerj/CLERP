using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Swagger.Filter
{
    /// <summary>
    /// Applies the data format for produced and consumed data for every endpoint / controller if nothing more concrete is specified
    /// </summary>
    public class DefaultDataFormatFilter : IOperationFilter
    {
        public void Apply(Operation operation, OperationFilterContext context)
        {
            const string defaultDataFormat = "application/json";

            // get all custom attributes from action or controller
            var customAttributes = context.MethodInfo.GetCustomAttributes(true);

            // only apply default consume format if nothing is defined directly in the controller or action whith the ConsumesAttribute
            if (!customAttributes.Any(attr => attr is ConsumesAttribute))
            {
                operation.Consumes.Clear();
                operation.Consumes.Add(defaultDataFormat);
            }

            // only apply default produce format if nothing is defined directly in the controller or action whith the ProducesAttribute
            if (!customAttributes.Any(attr => attr is ProducesAttribute))
            {
                operation.Produces.Clear();
                operation.Produces.Add(defaultDataFormat);
            }
        }
    }
}
