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
        [JsonProperty("parent-id")]
        public Guid ParentId { get; set; }

        /// <summary>
        /// Id of the product type which the parent should be removed from
        /// </summary>
        [JsonProperty("base-id")]
        public Guid BaseProductTypeId { get; set; }
    }
}
