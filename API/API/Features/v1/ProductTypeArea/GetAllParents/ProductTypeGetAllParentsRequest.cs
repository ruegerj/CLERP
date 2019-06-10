using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductTypeArea.GetAllParents
{
    public class ProductTypeGetAllParentsRequest : IRequest<ProductTypeGetAllParentsResponse>
    {
        /// <summary>
        /// Id of the child product type which the parents should be loaded
        /// </summary>
        [JsonProperty("childId")]
        public Guid ChildId { get; set; }
    }
}
