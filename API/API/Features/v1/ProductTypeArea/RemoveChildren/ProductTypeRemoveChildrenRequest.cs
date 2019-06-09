using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CLERP.API.Features.v1.ProductTypeArea.RemoveChildren
{
    public class ProductTypeRemoveChildrenRequest : IRequest
    {
        /// <summary>
        /// Ids of the children product types which should be removed
        /// </summary>
        [JsonProperty("childIds")]
        public IEnumerable<Guid> ChildIds { get; set; }

        /// <summary>
        /// Id of the product type which the child should be removed from
        /// </summary>
        [JsonProperty("baseId")]
        public Guid BaseProductTypeId { get; set; }
    }
}
