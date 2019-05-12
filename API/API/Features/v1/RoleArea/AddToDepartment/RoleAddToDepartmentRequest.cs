using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.RoleArea.AddToDepartment
{
    public class RoleAddToDepartmentRequest : IRequest<bool>
    {
        /// <summary>
        /// Id of the role whihc should be added to the department
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
