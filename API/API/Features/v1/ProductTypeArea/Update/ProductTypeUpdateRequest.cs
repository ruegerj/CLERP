using MediatR;
using Newtonsoft.Json;
using System;

namespace CLERP.API.Features.v1.ProductTypeArea.Update
{
    public class ProductTypeUpdateRequest : IRequest<ProductTypeResponse>
    {
        [JsonIgnore]
        public Guid ProductTypeGuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// European Article Number
        /// </summary>
        [JsonProperty("ean")]
        public string EAN { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// Image as base64 string
        /// </summary>
        [JsonProperty("imageBase64")]
        public string Image { get; set; }
    }
}
