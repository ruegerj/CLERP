using CLERP.API.Infrastructure.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea.GetAll
{
    public class EmployeeGetAllHandler : IRequestHandler<EmployeeGetAllRequest, EmployeeGetAllResponse>
    {
        private readonly ClerpContext _context;

        public EmployeeGetAllHandler(ClerpContext context)
        {
            _context = context;
        }

        public async Task<EmployeeGetAllResponse> Handle(EmployeeGetAllRequest request, CancellationToken cancellationToken)
        {
            var employeeDtos = await _context.Employees.Select(e => new EmployeeResponse()
            {
                Birthday = e.Birthday,
                Firstname = e.Firstname,
                Guid = e.Guid,
                Lastname = e.Lastname,
                PhoneNumber = e.PhoneNumber,
                Username = e.Username
            }).ToListAsync(cancellationToken);

            return new EmployeeGetAllResponse() { Employees = employeeDtos };
        }
    }
}
