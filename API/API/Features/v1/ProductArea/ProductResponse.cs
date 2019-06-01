using CLERP.API.Domain.Models.Abstract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductArea
{
    /// <summary>
    /// Default response dto for a product
    /// </summary>
    public class ProductResponse
    {
        [JsonProperty("id")]
        public Guid Guid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("state")]
        public ProductState State { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Include, PropertyName = "parentId")]
        public Guid? ParentGuid { get; set; }

        [JsonProperty("childIds")]
        public IEnumerable<Guid> ChildrenGuids { get; set; }

        [JsonProperty("productTypeId")]
        public Guid ProductTypeGuid { get; set; }

        [JsonProperty("compartmentId")]
        public Guid CompartmentGuid { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Include, PropertyName = "billId")]
        public Guid? BillGuid { get; set; }
    }
}
