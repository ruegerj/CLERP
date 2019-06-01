using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.RoleArea.RemoveFromDepartment
{
    public class RoleRemoveFromDepartmentHandler : AsyncRequestHandler<RoleRemoveFromDepartmentRequest>
    {
        private readonly ClerpContext _context;

        public RoleRemoveFromDepartmentHandler(ClerpContext context)
        {
            _context = context;
        }

        protected async override Task Handle(RoleRemoveFromDepartmentRequest request, CancellationToken cancellationToken)
        {
            var linkRoleDepartment = await _context.RolesDepartments.FindAsync(
                keyValues: new object[] { request.RoleId, request.DepartmentId },
                cancellationToken);

            if (linkRoleDepartment == null)
            {
                throw new BadRequestException(); // department doesn't have this role => can't be removed
            }

            _context.RolesDepartments.Remove(linkRoleDepartment);

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
