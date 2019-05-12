using CLERP.API.Domain.Models.Link;
using CLERP.API.Infrastructure.Contexts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.RoleArea.AddToEmployee
{
    public class RoleAddToEmployeeHandler : IRequestHandler<RoleAddToEmployeeRequest, bool>
    {
        private readonly ClerpContext _context;

        public RoleAddToEmployeeHandler(ClerpContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(RoleAddToEmployeeRequest request, CancellationToken cancellationToken)
        {
            var role = await _context.Roles.FindAsync(request.RoleId, cancellationToken);

            if (role == null)
            {
                return false;
            }

            var employee = await _context.Employees.FindAsync(request.EmployeeId, cancellationToken);

            if (employee == null)
            {
                return false;
            }

            role.Employees.Add(new RoleEmployee()
            {
                Employee = employee,
                Role = role
            });

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
