using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
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
            var linkRoleEmployee = await _context.RolesEmployees.FindAsync(
                keyValues: new object[] { request.RoleId, request.EmployeeId },
                cancellationToken);

            if (linkRoleEmployee == null)
            {
                throw new BadRequestException(); // department doesn't have this role => can't be removed
            }

            _context.RolesEmployees.Remove(linkRoleEmployee);

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
