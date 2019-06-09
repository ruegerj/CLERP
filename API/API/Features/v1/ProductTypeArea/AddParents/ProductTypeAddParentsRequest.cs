using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CLERP.API.Features.v1.ProductTypeArea.AddParent
{
    public class ProductTypeAddParentsRequest : IRequest
    {
        /// <summary>
        /// Ids of the new parents product types
        /// </summary>
        [JsonProperty("parentIds")]
        public IEnumerable<Guid> ParentIds { get; set; }

        /// <summary>
        /// Id of the product type which the parents product types should be added to
        /// </summary>
        [JsonProperty("baseId")]
        public Guid BaseProductTypeId { get; set; }
    }
}
