using AutoMapper;
using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea.GetById
{
    public class EmployeeGetByIdHandler : IRequestHandler<EmployeeGetByIdRequest, EmployeeResponse>
    {
        private readonly ClerpContext _context;
        private readonly IMapper _mapper;

        public EmployeeGetByIdHandler(ClerpContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<EmployeeResponse> Handle(EmployeeGetByIdRequest request, CancellationToken cancellationToken)
        {
            var employee = await _context.Employees
                .Include(e => e.Department)
                    .ThenInclude(d => d.Roles)
                        .ThenInclude(dr => dr.Role)
                .Include(e => e.Roles)
                    .ThenInclude(er => er.Role)
            .Select(e => new EmployeeResponse()
            {
                Birthday = e.Birthday,
                Firstname = e.Firstname,
                Guid = e.Guid,
                Lastname = e.Lastname,
                PhoneNumber = e.PhoneNumber,
                Username = e.Username,
                Email = e.Email,
                Department = _mapper.Map<Department, EmployeeDepartmentResponse>(e.Department),
                Roles = _mapper.Map<IEnumerable<Role>, IEnumerable<EmployeeRoleResponse>>(e.Roles.Select(er => er.Role)
                            .Concat(e.Department.Roles.Select(dr => dr.Role)))
            }).FirstOrDefaultAsync(e => e.Guid == request.EmployeeId, cancellationToken);

            if (employee == null)
            {
                return null;
            }

            return employee;
        }
    }
}
