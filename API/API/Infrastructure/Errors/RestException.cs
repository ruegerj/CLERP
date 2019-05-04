using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Errors
{
    /// <summary>
    /// Exception with HttpStatusCode which will be thrown in case something fails in the backend
    /// returns response directly via middleware
    /// </summary>
    public class RestException : Exception
    {
        public RestException(HttpStatusCode statusCode, object errors = null)
        {
            StatusCode = statusCode;
            Errors = errors;
        }

        public object Errors { get; set; }

        public HttpStatusCode StatusCode { get; set; }
    }
}
