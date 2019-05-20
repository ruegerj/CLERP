using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductTypeArea.Delete
{
    public class ProductTypeDeleteRequest : IRequest
    {
        public Guid ProductTypeGuid { get; set; }
    }
}
