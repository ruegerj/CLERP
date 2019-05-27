using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductTypeArea.RemoveChild
{
    public class ProductTypeRemoveChildHandler : AsyncRequestHandler<ProductTypeRemoveChildRequest>
    {
        private readonly ClerpContext _context;

        public ProductTypeRemoveChildHandler(ClerpContext context)
        {
            _context = context;
        }

        protected async override Task Handle(ProductTypeRemoveChildRequest request, CancellationToken cancellationToken)
        {
            var linkChildBase = await _context.ProductTypesProductTypes
                .FindAsync(keyValues: new object[] { request.BaseProductTypeId, request.ChildId }, cancellationToken: cancellationToken);

            if (linkChildBase == null)
            {
                throw new BadRequestException(); // link between base and child not found, can't remove relation 
            }

            _context.ProductTypesProductTypes.Remove(linkChildBase);

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
