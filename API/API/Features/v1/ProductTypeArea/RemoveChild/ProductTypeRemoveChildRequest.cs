using MediatR;
using Newtonsoft.Json;
using System;

namespace CLERP.API.Features.v1.ProductTypeArea.RemoveChild
{
    public class ProductTypeRemoveChildRequest : IRequest
    {
        /// <summary>
        /// Id of the child product type which should be removed
        /// </summary>
        [JsonProperty("childId")]
        public Guid ChildId { get; set; }

        /// <summary>
        /// Id of the product type which the child should be removed from
        /// </summary>
        [JsonProperty("baseId")]
        public Guid BaseProductTypeId { get; set; }
    }
}
