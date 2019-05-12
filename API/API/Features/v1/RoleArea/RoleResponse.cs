using CLERP.API.Domain.Models.Abstract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.RoleArea
{
    /// <summary>
    /// Default response dto for a role
    /// </summary>
    public class RoleResponse
    {
        [JsonProperty("id")]
        public Guid Guid { get; set; }

        /// <summary>
        /// Defines the explicit type / function
        /// </summary>
        [JsonProperty("type")]
        public RoleType Type { get; set; }

        /// <summary>
        /// Optional description of the role
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
