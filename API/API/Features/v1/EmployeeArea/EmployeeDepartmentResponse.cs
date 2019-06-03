using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea
{
    /// <summary>
    /// Default response dto for a department from an employee
    /// </summary>
    public class EmployeeDepartmentResponse
    {
        [JsonProperty("id")]
        public Guid Guid { get; set; }

        /// <summary>
        /// Title of the department
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Description of the deparment
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
