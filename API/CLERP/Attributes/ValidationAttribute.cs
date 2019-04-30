using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Attributes
{
    /// <summary>
    /// Custom attribute for erros in model validation
    /// Returns a custom formated error response if the validation of the model fails
    /// which lists all failed fields of the model
    /// </summary>   
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new ValidationFailedResult(context.ModelState);
            }
        }
    }

    /// <summary>
    /// Class to configure the default Http-Status code when the model validation fails
    /// Wraps arround the <see cref="ValidationResultModel"/>
    /// </summary>
    public class ValidationFailedResult : ObjectResult
    {
        public ValidationFailedResult(ModelStateDictionary modelState) : base(new ValidationResultModel(modelState))
        {
            StatusCode = StatusCodes.Status422UnprocessableEntity;
        }
    }

    /// <summary>
    /// Represents the summary of all validation errors
    /// Data-Format that will be returned after a failed validation
    /// </summary>
    public class ValidationResultModel
    {
        public ValidationResultModel(ModelStateDictionary modelState)
        {
            Message = "Validation failed";
            Errors = modelState.Keys
                        .SelectMany(key => modelState[key].Errors
                            .Select(e => new ValidationError(key, e.ErrorMessage)))
                        .ToList();
        }

        public string Message { get; }

        public List<ValidationError> Errors { get; }
    }

    /// <summary>
    /// Represents a validation error, occured when validating an incoming model
    /// </summary>
    public class ValidationError
    {
        public ValidationError(string field, string message)
        {
            Field = field != String.Empty ? field : null;
            Message = message;
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] // Ensure field will not be serialized in case of a null value
        public string Field { get; }

        public string Message { get; }
    }

}
