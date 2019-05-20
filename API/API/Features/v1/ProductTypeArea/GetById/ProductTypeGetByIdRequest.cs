using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductTypeArea.GetById
{
    public class ProductTypeGetByIdRequest : IRequest<ProductTypeResponse>
    {
        public Guid ProductTypeId { get; set; }
    }
}
