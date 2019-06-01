using Newtonsoft.Json;
using System;

namespace CLERP.API.Features.v1.RoleArea.Create
{
    public class RoleCreateResponse
    {
        /// <summary>
        /// Id of the new created role
        /// </summary>
        [JsonProperty("roleId")]
        public Guid RoleId { get; set; }
    }
}
