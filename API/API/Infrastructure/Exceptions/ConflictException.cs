using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Exceptions
{
    /// <summary>
    /// Exception which, when thrown, returns an result with the HttpStatusCode 409 - Conflict
    /// </summary>
    public class ConflictException : RestException
    {
        /// <summary>
        /// Creates a an excpetion when an conflict with the existing data happened
        /// </summary>
        public ConflictException() : base(HttpStatusCode.Conflict)
        {
        }

        /// <summary>
        /// Creates a an excpetion when an conflict with the existing data happened
        /// </summary>
        /// <param name="message">Message why the conflict happened</param>
        public ConflictException(string message) : base(HttpStatusCode.Conflict)
        {
            Payload = new
            {
                message
            };
        }

        /// <summary>
        /// Creates a an excpetion when an conflict with the existing data happened
        /// </summary>
        /// <param name="propertyName">Name of the property from the Dto whose value created the conflict</param>
        /// <param name="message">Description why this conflict happened</param>
        public ConflictException(string propertyName, string message) : base(HttpStatusCode.Conflict)
        {
            Payload = new
            {
                conflict = new
                {
                    property = propertyName,
                    message
                }
            };
        }
    }
}
