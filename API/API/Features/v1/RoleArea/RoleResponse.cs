﻿using Newtonsoft.Json;
using System;

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
        /// Name of the role
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional description of the role
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
