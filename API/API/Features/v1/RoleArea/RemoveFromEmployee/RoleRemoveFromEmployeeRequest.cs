using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.RoleArea.RemoveFromEmployee
{
    public class RoleRemoveFromEmployeeRequest : IRequest
    {
        /// <summary>
        /// Id of the role which should be removed from the employee
        /// </summary>
        [JsonProperty("role-id")]
        public Guid RoleId { get; set; }

        /// <summary>
        /// Id of the employee which the role should be removed from
        /// </summary>
        [JsonProperty("employee-id")]
        public Guid EmployeeId { get; set; }
    }
}
