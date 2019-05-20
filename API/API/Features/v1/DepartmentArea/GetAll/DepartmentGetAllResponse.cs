using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.DepartmentArea.GetAll
{
    public class DepartmentGetAllResponse
    {
        [JsonProperty("departments")]
        public IEnumerable<DepartmentResponse> Deparments { get; set; }
    }
}
