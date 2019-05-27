using MediatR;
using Newtonsoft.Json;
using System;

namespace CLERP.API.Features.v1.ProductTypeArea.RemoveParent
{
    public class ProductTypeRemoveParentRequest : IRequest
    {
        /// <summary>
        /// Id of the parent product type which should be removed
        /// </summary>
        [JsonProperty("parentId")]
        public Guid ParentId { get; set; }

        /// <summary>
        /// Id of the product type which the parent should be removed from
        /// </summary>
        [JsonProperty("baseId")]
        public Guid BaseProductTypeId { get; set; }
    }
}
