using CLERP.API.Domain.Models.Link;
using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
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
            var role = await _context.Roles.FindAsync(request.RoleId, cancellationToken);

            if (role == null)
            {
                throw new BadRequestException(); // role to add not found
            }

            var employee = await _context.Employees.FindAsync(request.EmployeeId, cancellationToken);

            if (employee == null)
            {
                throw new BadRequestException(); // employee to add role not found
            }

            role.Employees.Add(new RoleEmployee()
            {
                Employee = employee,
                Role = role
            });

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
