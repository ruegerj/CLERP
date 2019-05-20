using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.DepartmentArea
{
    /// <summary>
    /// Default response dto for a department
    /// </summary>
    public class DepartmentResponse
    {
        [JsonProperty("id")]
        public Guid Guid { get; set; }

        /// <summary>
        /// Title of the department
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Description of the deparment
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
