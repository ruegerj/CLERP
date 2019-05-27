using CLERP.API.Domain.Models.Link;
using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
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
            var role = await _context.Roles
                .Include(r => r.Departments)
                .FirstOrDefaultAsync(r => r.Guid == request.RoleId, cancellationToken);

            if (role == null)
            {
                throw new BadRequestException(); // role to add not found
            }

            var department = await _context.Departments.FindByGuidAsync(request.DepartmentId, cancellationToken);

            if (department == null)
            {
                throw new BadRequestException(); // department to add role not found
            }

            if (role.Departments.Select(d => d.Department).Any(d => d.Guid == department.Guid))
            {
                throw new ConflictException("role is already added to this department"); // role is already added to the department
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
