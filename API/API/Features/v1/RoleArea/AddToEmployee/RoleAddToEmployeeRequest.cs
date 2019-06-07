using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CLERP.API.Features.v1.RoleArea.AddToEmployee
{
    public class RoleAddToEmployeeRequest : IRequest
    {
        /// <summary>
        /// Ids of the roles which should be added to the employee
        /// </summary>
        [JsonProperty("roleId")]
        public IEnumerable<Guid> RoleIds { get; set; }

        /// <summary>
        /// Id of the employee which the role should be added to
        /// </summary>
        [JsonProperty("employeeId")]
        public Guid EmployeeId { get; set; }
    }
}
