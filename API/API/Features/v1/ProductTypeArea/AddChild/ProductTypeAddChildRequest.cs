using MediatR;
using Newtonsoft.Json;
using System;

namespace CLERP.API.Features.v1.ProductTypeArea.AddChild
{
    public class ProductTypeAddChildRequest : IRequest
    {
        /// <summary>
        /// Id of the new child product type
        /// </summary>
        [JsonProperty("child-id")]
        public Guid ChildId { get; set; }

        /// <summary>
        /// Id of the product type which the child product type should be added to
        /// </summary>
        [JsonProperty("base-id")]
        public Guid BaseProductTypeId { get; set; }
    }
}
