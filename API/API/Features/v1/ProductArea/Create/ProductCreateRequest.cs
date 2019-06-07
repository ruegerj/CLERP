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
        [JsonProperty("products")]
        public IEnumerable<ProductCreateRequestModel> Products { get; set; }
    }
}
