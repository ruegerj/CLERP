using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductTypeArea.GetAll
{
    public class ProductTypeGetAllResponse
    {
        [JsonProperty("product-types")]
        public IEnumerable<ProductTypeResponse> ProductTypes { get; set; }
    }
}
