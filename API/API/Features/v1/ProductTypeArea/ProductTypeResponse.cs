using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CLERP.API.Features.v1.ProductTypeArea
{
    /// <summary>
    /// Default response dto for a product type
    /// </summary>
    public class ProductTypeResponse
    {
        [JsonProperty("id")]
        public Guid Guid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        /// <summary>
        /// European articel number
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
        /// All ids from the entities related as children to this product type
        /// </summary>
        [JsonProperty("childIds")]
        public IEnumerable<Guid> ChildGuids { get; set; }

        /// <summary>
        /// All ids from the entities related as paretns to this product type
        /// </summary>
        [JsonProperty("parentIds")]
        public IEnumerable<Guid> ParentGuids { get; set; }
    }
}
