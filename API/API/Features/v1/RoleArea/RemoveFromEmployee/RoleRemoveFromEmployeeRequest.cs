using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CLERP.API.Features.v1.RoleArea.RemoveFromEmployee
{
    public class RoleRemoveFromEmployeeRequest : IRequest
    {
        /// <summary>
        /// Ids of the roles which should be removed from the employee
        /// </summary>
        [JsonProperty("roleId")]
        public IEnumerable<Guid> RoleIds { get; set; }

        /// <summary>
        /// Id of the employee which the role should be removed from
        /// </summary>
        [JsonProperty("employeeId")]
        public Guid EmployeeId { get; set; }
    }
}
