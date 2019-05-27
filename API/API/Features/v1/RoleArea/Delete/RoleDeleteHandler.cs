using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.RoleArea.Delete
{
    public class RoleDeleteHandler : AsyncRequestHandler<RoleDeleteRequest>
    {
        private readonly ClerpContext _context;

        public RoleDeleteHandler(ClerpContext context)
        {
            _context = context;
        }

        protected async override Task Handle(RoleDeleteRequest request, CancellationToken cancellationToken)
        {
            var roleToDelete = await _context.Roles.FindByGuidAsync(request.RoleId, cancellationToken);

            if (roleToDelete == null)
            {
                throw new BadRequestException(); // role to delete not found
            }

            _context.Roles.Remove(roleToDelete);

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
