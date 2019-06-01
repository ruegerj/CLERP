﻿using MediatR;
using Newtonsoft.Json;
using System;

namespace CLERP.API.Features.v1.ProductTypeArea.AddParent
{
    public class ProductTypeAddParentRequest : IRequest
    {
        /// <summary>
        /// Id of the new parent product type
        /// </summary>
        [JsonProperty("parentId")]
        public Guid ParentId { get; set; }

        /// <summary>
        /// Id of the product type which the parent product type should be added to
        /// </summary>
        [JsonProperty("baseId")]
        public Guid BaseProductTypeId { get; set; }
    }
}
