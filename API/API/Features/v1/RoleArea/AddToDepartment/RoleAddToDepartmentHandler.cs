using CLERP.API.Domain.Models.Link;
using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.RoleArea.AddToDepartment
{
    public class RoleAddToDepartmentHandler : AsyncRequestHandler<RoleAddToDepartmentRequest>
    {
        private readonly ClerpContext _context;

        public RoleAddToDepartmentHandler(ClerpContext context)
        {
            _context = context;
        }

        protected async override Task Handle(RoleAddToDepartmentRequest request, CancellationToken cancellationToken)
        {
            var role = await _context.Roles.FindAsync(request.RoleId, cancellationToken);

            if (role == null)
            {
                throw new BadRequestException(); // role to add not found
            }

            var department = await _context.Departments.FindAsync(request.DepartmentId, cancellationToken);

            if (department == null)
            {
                throw new BadRequestException(); // department to add role not found
            }

            role.Departments.Add(new RoleDepartment()
            {
                Role = role,
                Department = department
            });

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
