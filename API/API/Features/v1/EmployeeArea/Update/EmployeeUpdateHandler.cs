using AutoMapper;
using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using CLERP.API.Infrastructure.Security.Hashing;
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
        private readonly IPasswordHasher _hasher;

        public EmployeeUpdateHandler(ClerpContext context, 
            IMapper mapper, 
            IPasswordHasher hasher)
        {
            _context = context;
            _mapper = mapper;
            _hasher = hasher;
        }

        public async Task<EmployeeResponse> Handle(EmployeeUpdateRequest request, CancellationToken cancellationToken)
        {
            var employee = await _context.Employees.FindByGuidAsync(request.EmployeeId, cancellationToken);

            if (employee == null)
            {
                throw new BadRequestException(); // employee to update not found
            }

            employee.Birthday = request.Birthday;
            employee.Email = request.Email;
            employee.Firstname = request.Firstname;
            employee.Lastname = request.Lastname;

            // set new password only if the current and new pw are provided and the current password entered is correct
            if (!string.IsNullOrEmpty(request.CurrentPassword) 
                && !string.IsNullOrEmpty(request.NewPassword)
                && _hasher.PasswordMatches(request.CurrentPassword, employee.Password))
            {
                employee.Password = _hasher.HashPassword(request.NewPassword);
            }

            await _context.SaveChangesAsync(cancellationToken);

            return _mapper.Map<Employee, EmployeeResponse>(employee);
        }
    }
}
