using Newtonsoft.Json;
using System;

namespace CLERP.API.Features.v1.RoleArea.Create
{
    public class RoleCreateResponse
    {
        /// <summary>
        /// Id of the new created role
        /// </summary>
        [JsonProperty("role-id")]
        public Guid RoleId { get; set; }
    }
}
