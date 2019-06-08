using Newtonsoft.Json;

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
            Message = message;
        }

        /// <summary>
        /// Error message, which explains that something went wrong
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
