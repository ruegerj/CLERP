using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.DepartmentArea.RemoveEmployee
{
    public class DepartmentRemoveEmployeeRequest : IRequest
    {
        /// <summary>
        /// Id of the department which the employee should be removed from
        /// </summary>
        [JsonProperty("department-id")]
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// Id of the employee which should be removed from the department
        /// </summary>
        [JsonProperty("employee-id")]
        public Guid EmployeeId { get; set; }
    }
}
