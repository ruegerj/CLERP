using MediatR;
using Newtonsoft.Json;

namespace CLERP.API.Features.v1.DepartmentArea.Create
{
    public class DepartmentCreateRequest : IRequest<DepartmentCreateResponse>
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
