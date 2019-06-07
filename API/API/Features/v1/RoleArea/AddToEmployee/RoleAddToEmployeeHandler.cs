using CLERP.API.Domain.Models.Link;
using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.RoleArea.AddToEmployee
{
    public class RoleAddToEmployeeHandler : AsyncRequestHandler<RoleAddToEmployeeRequest>
    {
        private readonly ClerpContext _context;

        public RoleAddToEmployeeHandler(ClerpContext context)
        {
            _context = context;
        }

        protected async override Task Handle(RoleAddToEmployeeRequest request, CancellationToken cancellationToken)
        {
            // Load all requested roles including the employees which have these roles
            var roles = await _context.Roles.Where(r => request.RoleIds.Any(ri => ri == r.Guid))
                .Include(r => r.Employees)
                .ToListAsync(cancellationToken);

            // check if count of requested roles match the count of found roles
            if (roles.Count == 0 || roles.Count != request.RoleIds.Count())
            {
                throw new BadRequestException(); // not all roles to add not found
            }

            var employee = await _context.Employees.FindByGuidAsync(request.EmployeeId, cancellationToken);

            if (employee == null)
            {
                throw new BadRequestException(); // employee to add role not found
            }

            if (roles.Any(r => r.Employees.Any(er => er.EmployeeGuid == employee.Guid)))
            {
                throw new ConflictException("one or more roles are already added to this employee"); // one or more roles are already added to the employee
            }

            roles.ForEach(r =>
            {
                r.Employees.Add(new RoleEmployee()
                {
                    Employee = employee,
                    Role = r
                });
            });

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
