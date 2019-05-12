using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea.GetAll
{
    public class EmployeeGetAllResponse
    {
        [JsonProperty("employees")]
        public IEnumerable<EmployeeResponse> Employees { get; set; }
    }
}
