using CLERP.API.Domain.Models.Link;
using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductTypeArea.AddChildren
{
    public class ProductTypeAddChildrenHandler : AsyncRequestHandler<ProductTypeAddChildrenRequest>
    {
        private readonly ClerpContext _context;

        public ProductTypeAddChildrenHandler(ClerpContext context)
        {
            _context = context;
        }

        protected async override Task Handle(ProductTypeAddChildrenRequest request, CancellationToken cancellationToken)
        {
            var parentProductType = await _context.ProductTypes
                .Include(pt => pt.Children)
                .FirstOrDefaultAsync(pt => pt.Guid == request.BaseProductTypeId, cancellationToken);

            if (parentProductType == null)
            {
                throw new BadRequestException(); // parent to add to new children not found
            }

            foreach (var childId in request.ChildIds)
            {
                var child = await _context.ProductTypes.FindByGuidAsync(childId, cancellationToken);

                if (child == null)
                {
                    throw new BadRequestException(); // child to add couldn't be found, can't add child
                }

                if (parentProductType.Children.Any(c => c.ChildGuid == child.Guid))
                {
                    throw new ConflictException("cannot add child product type to product type, because its already added");
                }

                await _context.ProductTypesProductTypes.AddAsync(new ProductTypeProductType()
                {
                    Child = child,
                    Parent = parentProductType
                }, cancellationToken);
            }

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
