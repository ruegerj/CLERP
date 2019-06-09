using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CLERP.API.Features.v1.ProductTypeArea.RemoveParents
{
    public class ProductTypeRemoveParentsRequest : IRequest
    {
        /// <summary>
        /// Id of the parent product type which should be removed
        /// </summary>
        [JsonProperty("parentId")]
        public IEnumerable<Guid> ParentIds { get; set; }

        /// <summary>
        /// Id of the product type which the parent should be removed from
        /// </summary>
        [JsonProperty("baseId")]
        public Guid BaseProductTypeId { get; set; }
    }
}
