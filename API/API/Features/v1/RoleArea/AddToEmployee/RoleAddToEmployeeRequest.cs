using MediatR;
using Newtonsoft.Json;
using System;

namespace CLERP.API.Features.v1.RoleArea.AddToEmployee
{
    public class RoleAddToEmployeeRequest : IRequest
    {
        /// <summary>
        /// Id of the role which should be added to the employee
        /// </summary>
        [JsonProperty("roleId")]
        public Guid RoleId { get; set; }

        /// <summary>
        /// Id of the employee which the role should be added to
        /// </summary>
        [JsonProperty("employeeId")]
        public Guid EmployeeId { get; set; }
    }
}
