using MediatR;
using Newtonsoft.Json;
using System;

namespace CLERP.API.Features.v1.DepartmentArea.AddEmployee
{
    public class DepartmentAddEmployeeRequest : IRequest
    {
        /// <summary>
        /// Id of the department which the employee should be added to
        /// </summary>
        [JsonProperty("department-id")]
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// Id of the employee which should be added to the department
        /// </summary>
        [JsonProperty("employee-id")]
        public Guid EmployeeId { get; set; }
    }
}
