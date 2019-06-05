using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductArea.GetAll
{
    public class ProductGetAllResponse
    {
        [JsonProperty("products")]
        public IEnumerable<ProductResponse> Products { get; set; }
    }
}
