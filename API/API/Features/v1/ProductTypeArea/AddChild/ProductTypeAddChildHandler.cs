using CLERP.API.Domain.Models.Link;
using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductTypeArea.AddChild
{
    public class ProductTypeAddChildHandler : AsyncRequestHandler<ProductTypeAddChildRequest>
    {
        private readonly ClerpContext _context;

        public ProductTypeAddChildHandler(ClerpContext context)
        {
            _context = context;
        }

        protected async override Task Handle(ProductTypeAddChildRequest request, CancellationToken cancellationToken)
        {
            var parentProductType = await _context.ProductTypes.FindByGuidAsync(request.ChildId, cancellationToken);

            if (parentProductType == null)
            {
                throw new BadRequestException(); // parent to add to new child not found
            }

            var baseProductType = await _context.ProductTypes
                .Include(pt => pt.Children)
                .FirstOrDefaultAsync(pt => pt.Guid == request.BaseProductTypeId, cancellationToken);

            if (baseProductType == null)
            {
                throw new BadRequestException(); // product type to add parent not found
            }

            if (baseProductType.Children.Any(p => p.ChildGuid == request.ChildId))
            {
                throw new ConflictException("cannot add child product type to product type, because its already added");
            }

            await _context.ProductTypesProductTypes.AddAsync(new ProductTypeProductType()
            {
                Child = baseProductType,
                Parent = parentProductType
            });

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
