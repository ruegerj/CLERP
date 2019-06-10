using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductTypeArea.GetAllParents
{
    public class ProductTypeGetAllParentsResponse
    {
        [JsonProperty("parents")]
        public IEnumerable<ProductTypeResponse> Parents { get; set; }
    }
}
