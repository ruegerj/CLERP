using MediatR;
using Newtonsoft.Json;
using System;

namespace CLERP.API.Features.v1.RoleArea.RemoveFromDepartment
{
    public class RoleRemoveFromDepartmentRequest : IRequest
    {
        /// <summary>
        /// Id of the role which should be removed from the department
        /// </summary>
        [JsonProperty("roleId")]
        public Guid RoleId { get; set; }

        /// <summary>
        /// Id of the department to role should be removed from
        /// </summary>
        [JsonProperty("departmentId")]
        public Guid DepartmentId { get; set; }
    }
}
