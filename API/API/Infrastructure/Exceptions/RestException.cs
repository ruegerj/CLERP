using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Exceptions
{
    /// <summary>
    /// Base class for all rest exception implementations
    /// </summary>
    public abstract class RestException : Exception
    {
        public RestException(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }

        public HttpStatusCode StatusCode { get; set; }
        /// <summary>
        /// Container for detailed information about the erros happened
        /// </summary>
        public object Payload { get; set; }
    }
}
