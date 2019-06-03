using Newtonsoft.Json;
using System;
using System.Collections.Generic;

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

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("department")]
        public EmployeeDepartmentResponse Department { get; set; }

        [JsonProperty("roles")]
        public IEnumerable<EmployeeRoleResponse> Roles { get; set; }
    }
}
