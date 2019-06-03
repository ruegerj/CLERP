using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea
{
    /// <summary>
    /// Default response dto for a role from an employee
    /// </summary>
    public class EmployeeRoleResponse
    {
        [JsonProperty("id")]
        public Guid Guid { get; set; }

        /// <summary>
        /// Name of the role
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional description of the role
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
