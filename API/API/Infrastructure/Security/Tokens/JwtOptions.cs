using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Security.Tokens
{
    /// <summary>
    /// Configurations for the Jwt stored in the appsettings.json
    /// </summary>
    public class JwtOptions
    {
        /// <summary>
        /// Timespan which defines how long a token is valid
        /// </summary>
        public TimeSpan ValidFor { get; set; }
    }
}
