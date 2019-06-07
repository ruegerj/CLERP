using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductArea.Create
{
    public class ProductCreateResponse
    {
        [JsonProperty("products")]
        public IEnumerable<ProductCreateResponseModel> Products { get; set; }
    }
}
