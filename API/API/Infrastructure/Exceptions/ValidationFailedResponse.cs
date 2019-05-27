using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace CLERP.API.Infrastructure.Exceptions
{
    /// <summary>
    /// Represents the summary of all validation errors
    /// Data-Format that will be returned after a failed validation
    /// </summary>
    public class ValidationFailedResponse
    {
        [JsonIgnore]
        private const string validationFailedMessage = "Validation failed";

        /// <summary>
        /// Creates a new <see cref="ValidationFailedResponse"/> object with existing <see cref="ValidationError"/> objects
        /// </summary>
        /// <param name="validationErrors"></param>
        public ValidationFailedResponse(IEnumerable<ValidationError> validationErrors)
        {
            Message = validationFailedMessage;
            Errors = validationErrors.ToList();
        }

        /// <summary>
        /// Creates a new <see cref="ValidationFailedResponse"/> object based on the modelstate
        /// </summary>
        /// <param name="modelState">Current modelstate</param>
        public ValidationFailedResponse(ModelStateDictionary modelState)
        {
            Message = validationFailedMessage;
            Errors = modelState.Keys
                        .SelectMany(key => modelState[key].Errors
                            .Select(e => new ValidationError(key, e.ErrorMessage)))
                        .ToList();
        }

        [JsonProperty("message")]
        public string Message { get; }

        [JsonProperty("validation-errors")]
        public List<ValidationError> Errors { get; }
    }
}
