using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CLERP.API.Features.v1.ProductTypeArea.Create
{
    public class ProductTypeCreateRequest : IRequest<ProductTypeCreateResponse>
    {
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

        /// <summary>
        /// Collection with all ids of all parent product types
        /// </summary>
        [JsonProperty("parentIds")]
        public IEnumerable<Guid> ParentGuids { get; set; }

        /// <summary>
        /// Collection with all ids of all the child product types
        /// </summary>
        [JsonProperty("childIds")]
        public IEnumerable<Guid> ChildGuids { get; set; }
    }
}
