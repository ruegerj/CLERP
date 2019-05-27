using CLERP.API.Infrastructure.Middleware;
using System.Net;

namespace CLERP.API.Infrastructure.Exceptions
{
    /// <summary>
    /// Exception which, when thrown, returns an result with the HttpStatusCode 409 - Conflict
    /// </summary>
    /// <remarks>
    /// Will be catched and handled in the <see cref="ErrorHandlingMiddleware"/>
    /// </remarks>
    public class ConflictException : RestException<ConflictResponse>
    {
        /// <summary>
        /// Creates a an excpetion when an conflict with the existing data happened
        /// </summary>
        /// <param name="message">Message why the conflict happened</param>
        public ConflictException(string message) : base(HttpStatusCode.Conflict)
        {
            Payload = new ConflictResponse(message);
        }

        /// <summary>
        /// Creates a an excpetion when an conflict with the existing data happened
        /// </summary>
        /// <param name="propertyName">Name of the property from the Dto whose value created the conflict</param>
        /// <param name="message">Description why this conflict happened</param>
        public ConflictException(string propertyName, string message) : base(HttpStatusCode.Conflict)
        {
            Payload = new ConflictResponse(message, propertyName);
        }

        /// <summary>
        /// Contains information about the conflict
        /// </summary>
        public override ConflictResponse Payload { get; set; }
    }
}
