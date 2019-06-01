using Newtonsoft.Json;
using System.Collections.Generic;

namespace CLERP.API.Features.v1.EmployeeArea.GetAll
{
    public class EmployeeGetAllResponse
    {
        [JsonProperty("employees")]
        public IEnumerable<EmployeeResponse> Employees { get; set; }
    }
}
