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
    public class ProductTypeAddParentHandler : AsyncRequestHandler<ProductTypeAddParentRequest>
    {
        private readonly ClerpContext _context;

        public ProductTypeAddParentHandler(ClerpContext context)
        {
            _context = context;
        }

        protected async override Task Handle(ProductTypeAddParentRequest request, CancellationToken cancellationToken)
        {
            var parentProductType = await _context.ProductTypes.FindByGuidAsync(request.ParentId, cancellationToken);

            if (parentProductType == null)
            {
                throw new BadRequestException(); // parent to add to new child not found
            }

            var baseProductType = await _context.ProductTypes
                .Include(pt => pt.Parents)
                .FirstOrDefaultAsync(pt => pt.Guid == request.BaseProductTypeId, cancellationToken);

            if (baseProductType == null)
            {
                throw new BadRequestException(); // product type to add parent not found
            }

            if (baseProductType.Parents.Any(p => p.ParentGuid == request.ParentId))
            {
                throw new ConflictException("cannot add parent product type to product type, because its already added");
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
