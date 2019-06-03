using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea.Create
{
    public class EmployeeCreateResponse
    {
        /// <summary>
        /// Id of the created employee
        /// </summary>
        [JsonProperty("employeeId")]
        public Guid EmployeeId { get; set; }
    }
}
