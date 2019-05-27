using MediatR;
using Newtonsoft.Json;
using System;

namespace CLERP.API.Features.v1.RoleArea.AddToDepartment
{
    public class RoleAddToDepartmentRequest : IRequest
    {
        /// <summary>
        /// Id of the role which should be added to the department
        /// </summary>
        [JsonProperty("role-id")]
        public Guid RoleId { get; set; }

        /// <summary>
        /// Id of the department to role should be added to
        /// </summary>
        [JsonProperty("department-id")]
        public Guid DepartmentId { get; set; }
    }
}
