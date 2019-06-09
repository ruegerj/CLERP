using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductTypeArea.GetAllChildren
{
    public class ProductTypeGetAllChildrenRequest : IRequest<ProductTypeGetAllChildrenResponse>
    {
        /// <summary>
        /// Id of the parent product which children shoulb be loaded
        /// </summary>
        public Guid ParentGuid { get; set; }
    }
}
