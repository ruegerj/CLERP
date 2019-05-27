using Newtonsoft.Json;
using System;

namespace CLERP.API.Features.v1.DepartmentArea.Create
{
    public class DepartmentCreateResponse
    {
        /// <summary>
        /// Id of the generated department
        /// </summary>
        [JsonProperty("departmentId")]
        public Guid DepartmentId { get; set; }
    }
}
