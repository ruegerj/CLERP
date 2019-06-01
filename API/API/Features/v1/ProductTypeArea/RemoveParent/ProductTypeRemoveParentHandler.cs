using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductTypeArea.RemoveParent
{
    public class ProductTypeRemoveParentHandler : AsyncRequestHandler<ProductTypeRemoveParentRequest>
    {
        private readonly ClerpContext _context;

        public ProductTypeRemoveParentHandler(ClerpContext context)
        {
            _context = context;
        }

        protected async override Task Handle(ProductTypeRemoveParentRequest request, CancellationToken cancellationToken)
        {
            var linkParentBase = await _context.ProductTypesProductTypes
                .FindAsync(keyValues: new object[] { request.ParentId, request.BaseProductTypeId }, cancellationToken: cancellationToken);

            if (linkParentBase == null)
            {
                throw new BadRequestException(); // link between base and parent not found, can't remove relation
            }

            _context.ProductTypesProductTypes.Remove(linkParentBase);

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
