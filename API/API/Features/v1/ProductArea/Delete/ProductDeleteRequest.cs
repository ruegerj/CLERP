using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductArea.Delete
{
    public class ProductDeleteRequest : IRequest
    {
        public Guid ProductGuid { get; set; }
    }
}
