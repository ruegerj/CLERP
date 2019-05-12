using AutoMapper;
using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Contexts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea.Update
{
    public class EmployeeUpdateHandler : IRequestHandler<EmployeeUpdateRequest, EmployeeResponse>
    {
        private readonly ClerpContext _context;
        private readonly IMapper _mapper;

        public EmployeeUpdateHandler(ClerpContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<EmployeeResponse> Handle(EmployeeUpdateRequest request, CancellationToken cancellationToken)
        {
            var employee = await _context.Employees.FindAsync(request.EmployeeId, cancellationToken);

            if (employee == null)
            {
                return null;
            }

            employee.Birthday = request.Birthday;
            employee.Email = request.Email;
            employee.Firstname = request.Firstname;
            employee.Lastname = request.Lastname;

            await _context.SaveChangesAsync(cancellationToken);

            return _mapper.Map<Employee, EmployeeResponse>(employee);
        }
    }
}
