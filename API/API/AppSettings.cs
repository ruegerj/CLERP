using CLERP.API.Infrastructure.Security.Jwt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLERP.API
{
    /// <summary>
    /// Represents the custom settings from the appsettings.json file
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// Connection-String to local dev DB
        /// </summary>
        public string ConnectionStringLocal { get; set; }

        /// <summary>
        /// Configurations for the Jwt's
        /// </summary>
        public JwtOptions JwtOptions { get; set; }
    }
}
