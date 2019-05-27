using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductTypeArea.Delete
{
    public class ProductTypeDeleteHandler : AsyncRequestHandler<ProductTypeDeleteRequest>
    {
        private readonly ClerpContext _context;

        public ProductTypeDeleteHandler(ClerpContext context)
        {
            _context = context;
        }

        protected async override Task Handle(ProductTypeDeleteRequest request, CancellationToken cancellationToken)
        {
            var productType = await _context.ProductTypes.FindByGuidAsync(request.ProductTypeGuid, cancellationToken);

            if (productType == null)
            {
                throw new BadRequestException(); //  product type to delete not found
            }

            _context.ProductTypes.Remove(productType);

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
