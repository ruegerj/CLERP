using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Security.Jwt
{
    /// <summary>
    /// Configurations for the Jwt stored in the appsettings.json
    /// </summary>
    public class JwtOptions
    {
        /// <summary>
        /// Secret private key to generate and validate Jwt-Tokens against
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Timespan whihc defines how long a token is valid
        /// </summary>
        public TimeSpan ValidFor { get; set; }

        /// <summary>
        /// Returns the bytes from key
        /// </summary>
        public byte[] GetBytesFromKey
        {
            get
            {
                return Encoding.UTF8.GetBytes(Key);
            }
        }
    }
}
