using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea
{
    /// <summary>
    /// Default response dto for an employee
    /// </summary>
    public class EmployeeResponse
    {
        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("birthday")]
        public DateTime Birthday { get; set; }

        [JsonProperty("phone-number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}
