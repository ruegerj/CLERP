using Newtonsoft.Json;

namespace CLERP.API.Features.v1
{
    /// <summary>
    /// A response contianer when just a message have to be returned
    /// </summary>
    public class MessageResponse
    {
        public MessageResponse(string message)
        {
            Message = message;
        }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
