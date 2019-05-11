using CLERP.API.Infrastructure.Security.Tokens;
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
        /// Connection-string to local dev DB
        /// </summary>
        public string ConnectionstringLocal { get; set; }
    }
}
