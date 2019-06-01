using CLERP.API.Infrastructure.Middleware;
using System.Net;

namespace CLERP.API.Infrastructure.Exceptions
{
    /// <summary>
    /// Exception which, when thrown, returns an result with the HttpStatusCode 400 - BadRequest
    /// </summary>
    /// <remarks>
    /// Will be catched and handled in the <see cref="ErrorHandlingMiddleware"/>
    /// </remarks>
    public class BadRequestException : RestException<BadRequestResponse>
    {
        /// <summary>
        /// Creates an exception with a default message, when something strange happened but it is no system exception
        /// => e.g. Id which doesn't exist
        /// </summary>
        public BadRequestException() : base(HttpStatusCode.BadRequest)
        {
            Payload = new BadRequestResponse("Something went wrong, plesae try it again");
        }

        /// <summary>
        /// Creates an exception when something strange happened but it is no system exception
        /// => e.g. Id which doesn't exist
        /// </summary>
        /// <param name="message">Custom message that will be returned in the response body</param>
        public BadRequestException(string message) : base(HttpStatusCode.BadRequest)
        {
            Payload = new BadRequestResponse(message);
        }

        /// <summary>
        /// Contains the provided message
        /// </summary>
        public override BadRequestResponse Payload { get; set; }
    }
}
