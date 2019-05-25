using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductTypeArea.RemoveChild
{
    public class ProductTypeRemoveChildRequest : IRequest
    {
        /// <summary>
        /// Id of the child product type which should be removed
        /// </summary>
        [JsonProperty("child-id")]
        public Guid ChildId { get; set; }

        /// <summary>
        /// Id of the product type which the child should be removed from
        /// </summary>
        [JsonProperty("base-id")]
        public Guid BaseProductTypeId { get; set; }
    }
}
