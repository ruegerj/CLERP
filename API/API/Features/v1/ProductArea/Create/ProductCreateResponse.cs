using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductArea.Create
{
    public class ProductCreateResponse
    {
        /// <summary>
        /// Id of the created product
        /// </summary>
        [JsonProperty("productId")]
        public Guid ProductGuid { get; set; }
    }
}
