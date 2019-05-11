using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Exceptions
{
    public class ConflictResponse
    {
        /// <summary>
        /// Creates an new <see cref="ConflictResponse"/> with a message only
        /// </summary>
        /// <param name="message">Message why the conflict happened</param>
        public ConflictResponse(string message)
        {
            Message = message;
            FieldName = null; // set null so it wont be serialized
        }

        /// <summary>
        /// Creates an new <see cref="ConflictResponse"/> with the message and the field-name
        /// </summary>
        /// <param name="message">Message why the conflict happened</param>
        /// <param name="fieldName">Name of the field/property which caused the conflict</param>
        public ConflictResponse(string message, string fieldName) : this(message)
        {
            FieldName = fieldName.ToLower();
        }

        /// <summary>
        /// Name of the property which caused the conflict
        /// </summary>
        [JsonProperty("field")]
        public string FieldName { get; }

        /// <summary>
        /// Message about the reason/background of the conflict
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
