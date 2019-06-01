using Newtonsoft.Json;
using System.Collections.Generic;

namespace CLERP.API.Features.v1.DepartmentArea.GetAll
{
    public class DepartmentGetAllResponse
    {
        [JsonProperty("departments")]
        public IEnumerable<DepartmentResponse> Deparments { get; set; }
    }
}
