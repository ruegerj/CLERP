using CLERP.API.Domain.Models.Abstract;
using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductArea.Create
{
    public class ProductCreateRequest : IRequest<ProductCreateResponse>
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Include, PropertyName = "parentId")]
        public Guid? ParentGuid { get; set; }

        [JsonProperty("childrenIds")]
        public IEnumerable<Guid> ChildrenGuids { get; set; }

        [JsonProperty("productTypeId")]
        public Guid TypeGuid { get; set; }

        [JsonProperty("compartmentId")]
        public Guid CompartmentGuid { get; set; }
    }
}
