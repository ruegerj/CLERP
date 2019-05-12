using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.RoleArea.GetAll
{
    public class RoleGetAllResponse
    {
        [JsonProperty("roles")]
        public IEnumerable<RoleResponse> Roles { get; set; }
    }
}
