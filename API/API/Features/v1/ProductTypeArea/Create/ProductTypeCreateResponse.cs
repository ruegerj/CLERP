using Newtonsoft.Json;
using System;

namespace CLERP.API.Features.v1.ProductTypeArea.Create
{
    public class ProductTypeCreateResponse
    {
        /// <summary>
        /// Id of the created product type
        /// </summary>
        [JsonProperty("product-type-id")]
        public Guid ProductTypeGuid { get; set; }
    }
}
