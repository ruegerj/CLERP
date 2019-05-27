using Newtonsoft.Json;
using System.Collections.Generic;

namespace CLERP.API.Features.v1.RoleArea.GetAll
{
    public class RoleGetAllResponse
    {
        [JsonProperty("roles")]
        public IEnumerable<RoleResponse> Roles { get; set; }
    }
}
