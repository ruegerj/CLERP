using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.DepartmentArea.Create
{
    public class DepartmentCreateResponse
    {
        /// <summary>
        /// Id of the generated department
        /// </summary>
        [JsonProperty("department-id")]
        public Guid DepartmentId { get; set; }
    }
}
