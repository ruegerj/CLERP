using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.DepartmentArea.RemoveEmployee
{
    public class DepartmentRemoveEmployeeHandler : AsyncRequestHandler<DepartmentRemoveEmployeeRequest>
    {
        private readonly ClerpContext _context;

        public DepartmentRemoveEmployeeHandler(ClerpContext context)
        {
            _context = context;
        }

        protected async override Task Handle(DepartmentRemoveEmployeeRequest request, CancellationToken cancellationToken)
        {
            var department = await _context.Departments
                .Include(d => d.Employees)
                .FirstOrDefaultAsync(d => d.Guid == request.DepartmentId, cancellationToken);

            if (department == null)
            {
                throw new BadRequestException(); // department to remove employee from not found
            }

            var employee = await _context.Employees.FindByGuidAsync(request.EmployeeId, cancellationToken);

            if (employee == null)
            {
                throw new BadRequestException(); // employee to remove from the department not found
            }

            if (!department.Employees.Any(e => e.Guid == employee.Guid))
            {
                throw new BadRequestException(); // department doesn't have this employee added => can't be removed
            }

            department.Employees.Remove(employee);

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
