using MediatR;
using Newtonsoft.Json;

namespace CLERP.API.Features.v1.RoleArea.Create
{
    public class RoleCreateRequest : IRequest<RoleCreateResponse>
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
