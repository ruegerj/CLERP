using MediatR;
using System;

namespace CLERP.API.Features.v1.ProductTypeArea.Delete
{
    public class ProductTypeDeleteRequest : IRequest
    {
        public Guid ProductTypeGuid { get; set; }
    }
}
