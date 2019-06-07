using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductArea.Create
{
    public class ProductCreateResponseModel
    {
        /// <summary>
        /// Serialnumber to match the new id to the product
        /// </summary>
        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Id of the created product
        /// </summary>
        [JsonProperty("productId")]
        public Guid ProductGuid { get; set; }
    }
}
