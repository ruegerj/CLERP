using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductTypeArea.RemoveParents
{
    public class ProductTypeRemoveParentsHandler : AsyncRequestHandler<ProductTypeRemoveParentsRequest>
    {
        private readonly ClerpContext _context;

        public ProductTypeRemoveParentsHandler(ClerpContext context)
        {
            _context = context;
        }

        protected async override Task Handle(ProductTypeRemoveParentsRequest request, CancellationToken cancellationToken)
        {
            var linksParentsBase = await _context.ProductTypesProductTypes
                                    .Where(pt => pt.ChildGuid == request.BaseProductTypeId
                                    && request.ParentIds.Any(pi => pi == pt.ParentGuid))
                                    .ToListAsync(cancellationToken);

            if (linksParentsBase.Count == 0 || linksParentsBase.Count != request.ParentIds.Count())
            {
                throw new BadRequestException(); // link between base and parents not found, can't remove relation
            }

            linksParentsBase.ForEach(lpb => _context.ProductTypesProductTypes.Remove(lpb));

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
