using System;
using System.Net;

namespace CLERP.API.Infrastructure.Exceptions
{
    /// <summary>
    /// All derived types of this class will be catched in the <see cref="Middleware.ErrorHandlingMiddleware"/>
    /// and handled there
    /// </summary>
    /// <typeparam name="TPayload">Type of the payload from the derived implementation</typeparam>
    public abstract class RestException<TPayload> : Exception where TPayload : class
    {
        public RestException(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }

        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// Container / Struct, which is defined in the derived types constructors, for detailed information why the error/s happened
        /// </summary>
        public abstract TPayload Payload { get; set; }
    }
}
