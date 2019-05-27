using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.DepartmentArea.AddEmployee
{
    public class DepartmentAddEmployeeHandler : AsyncRequestHandler<DepartmentAddEmployeeRequest>
    {
        private readonly ClerpContext _context;

        public DepartmentAddEmployeeHandler(ClerpContext context)
        {
            _context = context;
        }

        protected async override Task Handle(DepartmentAddEmployeeRequest request, CancellationToken cancellationToken)
        {
            var department = await _context.Departments
                .Include(d => d.Employees)
                .FirstOrDefaultAsync(d => d.Guid == request.DepartmentId, cancellationToken);

            if (department == null)
            {
                throw new BadRequestException(); // department to add employee not found
            }

            var employee = await _context.Employees.FindByGuidAsync(request.EmployeeId, cancellationToken);

            if (employee == null)
            {
                throw new BadRequestException(); // employee to add to department not found
            }

            if (department.Employees.Any(e => e.Guid == employee.Guid))
            {
                throw new ConflictException("employee is already added to this department"); // employee is already added to this department
            }

            department.Employees.Add(employee);

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
