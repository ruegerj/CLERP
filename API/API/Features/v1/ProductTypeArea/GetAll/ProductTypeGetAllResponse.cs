using Newtonsoft.Json;
using System.Collections.Generic;

namespace CLERP.API.Features.v1.ProductTypeArea.GetAll
{
    public class ProductTypeGetAllResponse
    {
        [JsonProperty("productTypes")]
        public IEnumerable<ProductTypeResponse> ProductTypes { get; set; }
    }
}
