using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductTypeArea.RemoveChildren
{
    public class ProductTypeRemoveChildrenHandler : AsyncRequestHandler<ProductTypeRemoveChildrenRequest>
    {
        private readonly ClerpContext _context;

        public ProductTypeRemoveChildrenHandler(ClerpContext context)
        {
            _context = context;
        }

        protected async override Task Handle(ProductTypeRemoveChildrenRequest request, CancellationToken cancellationToken)
        {
            var linksProductTypesProductTypes = await _context.ProductTypesProductTypes
                .Where(pt => request.ChildIds.Any(ci => ci == pt.ChildGuid)
                    && pt.ParentGuid == request.BaseProductTypeId)
                .ToListAsync(cancellationToken);

            if (linksProductTypesProductTypes.Count == 0 || linksProductTypesProductTypes.Count != request.ChildIds.Count())
            {
                throw new BadRequestException(); // parent product type doesn't have one or more of the roles which should be removed
            }

            linksProductTypesProductTypes.ForEach(lpt => _context.ProductTypesProductTypes.Remove(lpt));

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
