namespace CLERP.API.Features.v1
{
    /// <summary>
    /// Default container for every success response
    /// </summary>
    public class ResponseContainer
    {
        public ResponseContainer(string message)
        {
            Message = message;
        }

        public ResponseContainer(string message, object payload) : this(message)
        {
            Payload = payload;
        }

        public string Message { get; set; }

        /// <summary>
        /// Contains the data for the reponse, if existing
        /// </summary>
        public object Payload { get; set; }
    }
}
