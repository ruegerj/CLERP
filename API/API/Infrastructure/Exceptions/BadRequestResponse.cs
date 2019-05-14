using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Exceptions
{
    /// <summary>
    /// Payload of <see cref="BadRequestException"/>
    /// </summary>
    public class BadRequestResponse
    {
        /// <summary>
        /// Creates a new <see cref="BadRequestResponse"/> with an error message
        /// </summary>
        /// <param name="message"></param>
        public BadRequestResponse(string message)
        {
            ErrorMessage = message;
        }

        /// <summary>
        /// Error message, which explains that something went wrong
        /// </summary>
        [JsonProperty("error-message")]
        public string ErrorMessage { get; set; }
    }
}
