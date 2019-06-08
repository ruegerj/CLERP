using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductArea.Delete
{
    public class ProductDeleteHandler : AsyncRequestHandler<ProductDeleteRequest>
    {
        private readonly ClerpContext _context;

        public ProductDeleteHandler(ClerpContext context)
        {
            _context = context;
        }

        protected async override Task Handle(ProductDeleteRequest request, CancellationToken cancellationToken)
        {
            var product = await _context.Products.FindByGuidAsync(request.ProductGuid, cancellationToken);

            if (product == null)
            {
                throw new BadRequestException(); // product coulnd't be found => cant delete product
            }

            _context.Products.Remove(product);

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
