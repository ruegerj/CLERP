using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea.Login
{
    /// <summary>
    /// Response after an employee is logged in
    /// </summary>
    public class TokenResponse
    {
        /// <summary>
        /// Access token for the employee
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
