using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CLERP.API.Features.v1.ProductTypeArea.AddChildren
{
    public class ProductTypeAddChildrenRequest : IRequest
    {
        /// <summary>
        /// Ids from the new children for the product type
        /// </summary>
        [JsonProperty("childIds")]
        public IEnumerable<Guid> ChildIds { get; set; }

        /// <summary>
        /// Id of the product type which the child product type should be added to
        /// </summary>
        [JsonProperty("baseId")]
        public Guid BaseProductTypeId { get; set; }
    }
}
