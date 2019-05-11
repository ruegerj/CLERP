using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Attributes
{
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
}
