using CLERP.API.Domain.Models.Link;
using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductTypeArea.AddParent
{
    public class ProductTypeAddParentsHandler : AsyncRequestHandler<ProductTypeAddParentsRequest>
    {
        private readonly ClerpContext _context;

        public ProductTypeAddParentsHandler(ClerpContext context)
        {
            _context = context;
        }

        protected async override Task Handle(ProductTypeAddParentsRequest request, CancellationToken cancellationToken)
        {
            var childProductType = await _context.ProductTypes
                                    .Include(pt => pt.Parents)
                                    .FirstOrDefaultAsync(pt => pt.Guid == request.BaseProductTypeId);

            if (childProductType == null)
            {
                throw new BadRequestException(); // child to add new parent to couldn't be found
            }

            foreach (var parentId in request.ParentIds)
            {
                var parentProductType = await _context.ProductTypes.FindByGuidAsync(parentId, cancellationToken);

                if (parentProductType == null)
                {
                    throw new BadRequestException(); // parent product type to add couldn't be found
                }

                if (childProductType.Parents.Any(p => p.ParentGuid == parentProductType.Guid))
                {
                    throw new ConflictException("cannot add parent product type to product type, because its already added");
                }

                await _context.ProductTypesProductTypes.AddAsync(new ProductTypeProductType()
                {
                    Child = childProductType,
                    Parent = parentProductType
                }, cancellationToken);
            }

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
