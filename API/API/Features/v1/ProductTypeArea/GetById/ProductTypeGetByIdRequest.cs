using MediatR;
using System;

namespace CLERP.API.Features.v1.ProductTypeArea.GetById
{
    public class ProductTypeGetByIdRequest : IRequest<ProductTypeResponse>
    {
        public Guid ProductTypeId { get; set; }
    }
}
