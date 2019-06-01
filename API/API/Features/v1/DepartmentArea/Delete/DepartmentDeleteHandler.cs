using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.DepartmentArea.Delete
{
    public class DepartmentDeleteHandler : AsyncRequestHandler<DepartmentDeleteRequest>
    {
        private readonly ClerpContext _context;

        public DepartmentDeleteHandler(ClerpContext context)
        {
            _context = context;
        }

        protected async override Task Handle(DepartmentDeleteRequest request, CancellationToken cancellationToken)
        {
            var department = await _context.Departments.FindByGuidAsync(request.RoleId, cancellationToken);

            if (department == null)
            {
                throw new BadRequestException(); // department to delete not found
            }

            _context.Departments.Remove(department);

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
