using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
