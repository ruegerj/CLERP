using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductArea.GetById
{
    public class ProductGetByIdRequest : IRequest<ProductResponse>
    {
        public Guid ProductId { get; set; }
    }
}
