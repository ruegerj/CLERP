using MediatR;
using Newtonsoft.Json;
using System;

namespace CLERP.API.Features.v1.RoleArea.RemoveFromEmployee
{
    public class RoleRemoveFromEmployeeRequest : IRequest
    {
        /// <summary>
        /// Id of the role which should be removed from the employee
        /// </summary>
        [JsonProperty("roleId")]
        public Guid RoleId { get; set; }

        /// <summary>
        /// Id of the employee which the role should be removed from
        /// </summary>
        [JsonProperty("employeeId")]
        public Guid EmployeeId { get; set; }
    }
}
