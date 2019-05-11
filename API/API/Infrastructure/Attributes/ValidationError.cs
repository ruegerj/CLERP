using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Attributes
{
    /// <summary>
    /// Represents a validation error, occured when validating an incoming model
    /// </summary>
    public class ValidationError
    {
        public ValidationError(string field, string message)
        {
            Field = field != string.Empty ? field : null;
            Message = message;
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "field")] // Ensure field will not be serialized in case of a null value
        public string Field { get; }

        [JsonProperty("message")]
        public string Message { get; }
    }
}
