using CLERP.API.Infrastructure.Contexts;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea.Delete
{
    public class EmployeeDeleteHandler : IRequestHandler<EmployeeDeleteRequest, bool>
    {
        private readonly ClerpContext _context;

        public EmployeeDeleteHandler(ClerpContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(EmployeeDeleteRequest request, CancellationToken cancellationToken)
        {
            var employee = await _context.Employees.FindAsync(request.EmployeeId, cancellationToken);

            if (employee == null)
            {
                return false;
            }

            _context.Employees.Remove(employee);

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
