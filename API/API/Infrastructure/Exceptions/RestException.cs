using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Exceptions
{
    /// <summary>
    /// All derived types of this class will be catched in the <see cref="Middleware.ErrorHandlingMiddleware"/>
    /// and will be handled there
    /// </summary>
    public abstract class RestException : Exception
    {
        public RestException(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }

        public HttpStatusCode StatusCode { get; set; }
        /// <summary>
        /// Container / Struct, which is defined in the derived types constructors, for detailed information why the error/s happened
        /// </summary>
        public object Payload { get; set; }
    }
}
