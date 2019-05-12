using CLERP.API.Domain.Models.Link;
using CLERP.API.Infrastructure.Contexts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.RoleArea.AddToDepartment
{
    public class RoleAddToDepartmentHandler : IRequestHandler<RoleAddToDepartmentRequest, bool>
    {
        private readonly ClerpContext _context;

        public RoleAddToDepartmentHandler(ClerpContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(RoleAddToDepartmentRequest request, CancellationToken cancellationToken)
        {
            var role = await _context.Roles.FindAsync(request.RoleId, cancellationToken);

            if (role == null)
            {
                return false;
            }

            var department = await _context.Departments.FindAsync(request.DepartmentId, cancellationToken);

            if (department == null)
            {
                return false;
            }

            role.Departments.Add(new RoleDepartment()
            {
                Role = role,
                Department = department
            });

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
