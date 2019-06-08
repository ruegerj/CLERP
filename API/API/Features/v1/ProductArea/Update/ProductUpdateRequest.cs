using CLERP.API.Domain.Models.Abstract;
using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductArea.Update
{
    public class ProductUpdateRequest : IRequest<ProductResponse>
    {
        [JsonIgnore]
        public Guid ProductGuid { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("state")]
        public ProductState State { get; set; }

        [JsonProperty("compartmentId")]
        public Guid CompartmentGuid { get; set; }
    }
}
