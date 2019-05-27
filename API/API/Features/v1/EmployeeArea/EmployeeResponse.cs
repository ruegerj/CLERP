using Newtonsoft.Json;
using System;

namespace CLERP.API.Features.v1.EmployeeArea
{
    /// <summary>
    /// Default response dto for an employee
    /// </summary>
    public class EmployeeResponse
    {
        [JsonProperty("id")]
        public Guid Guid { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("birthday")]
        public DateTime Birthday { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}
