using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductTypeArea.GetAllChildren
{
    public class ProductTypeGetAllChildrenResponse
    {
        /// <summary>
        /// All first level children of the product type
        /// </summary>
        [JsonProperty("children")]
        public IEnumerable<ProductTypeResponse> Children { get; set; }
    }
}
