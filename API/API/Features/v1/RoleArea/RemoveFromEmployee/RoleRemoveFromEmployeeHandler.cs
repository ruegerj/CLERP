using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.RoleArea.RemoveFromEmployee
{
    public class RoleRemoveFromEmployeeHandler : AsyncRequestHandler<RoleRemoveFromEmployeeRequest>
    {
        private readonly ClerpContext _context;

        public RoleRemoveFromEmployeeHandler(ClerpContext context)
        {
            _context = context;
        }

        protected async override Task Handle(RoleRemoveFromEmployeeRequest request, CancellationToken cancellationToken)
        {
            var linksRolesEmployees = await _context.RolesEmployees
                .Where(re => request.RoleIds.Any(ri => ri == re.RoleGuid)
                    && re.EmployeeGuid == request.EmployeeId)
                .ToListAsync(cancellationToken);

            // check if all roles which should be removed could be found
            if (linksRolesEmployees.Count == 0 || linksRolesEmployees.Count != request.RoleIds.Count())
            {
                throw new BadRequestException(); // department doesn't have these roles => can't be removed
            }

            linksRolesEmployees.ForEach(lre => _context.RolesEmployees.Remove(lre));

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
