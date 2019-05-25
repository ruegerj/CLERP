using CLERP.API.Domain.Models.Link;
using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
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
            // Load role including the employees whi^ch have this role
            var role = await _context.Roles.Where(r => r.Guid == request.RoleId)
                .Include(r => r.Employees)
                .FirstOrDefaultAsync();

            if (role == null)
            {
                throw new BadRequestException(); // role to add not found
            }

            var employee = await _context.Employees.FindByGuidAsync(request.EmployeeId, cancellationToken);

            if (employee == null)
            {
                throw new BadRequestException(); // employee to add role not found
            }

            if (role.Employees.Any(e => e.EmployeeGuid == employee.Guid))
            {
                throw new ConflictException("role is already added to this employee"); // role is already added to the employee
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
