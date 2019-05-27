using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea.Delete
{
    public class EmployeeDeleteHandler : AsyncRequestHandler<EmployeeDeleteRequest>
    {
        private readonly ClerpContext _context;

        public EmployeeDeleteHandler(ClerpContext context)
        {
            _context = context;
        }

        protected async override Task Handle(EmployeeDeleteRequest request, CancellationToken cancellationToken)
        {
            var employee = await _context.Employees.FindByGuidAsync(request.EmployeeId, cancellationToken);

            if (employee == null)
            {
                throw new BadRequestException(); // employee to delete not found
            }

            _context.Employees.Remove(employee);

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
