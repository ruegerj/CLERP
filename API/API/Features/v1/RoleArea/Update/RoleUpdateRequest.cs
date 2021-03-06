﻿using MediatR;
using Newtonsoft.Json;
using System;

namespace CLERP.API.Features.v1.RoleArea.Update
{
    public class RoleUpdateRequest : IRequest<RoleResponse>
    {
        [JsonIgnore]
        public Guid RoleId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
