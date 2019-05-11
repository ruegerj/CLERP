using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Security.Hashing;
using CLERP.API.Infrastructure.Security.Tokens;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea.Login
{
    public class EmployeeLoginHandler : IRequestHandler<EmployeeLoginDto, string>
    {
        private readonly ClerpContext _context;
        private readonly ILogger<EmployeeLoginHandler> _logger;
        private readonly IPasswordHasher _hasher;
        private readonly IJwtTokenGenerator _tokenGenerator;

        public EmployeeLoginHandler(ClerpContext context, 
            ILogger<EmployeeLoginHandler> logger, 
            IPasswordHasher hasher,
            IJwtTokenGenerator tokenGenerator)
        {
            _context = context;
            _logger = logger;
            _hasher = hasher;
            _tokenGenerator = tokenGenerator;
        }

        /// <summary>
        /// Creates an Jwt for an employee if credentials are correct
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>token or null when credentials are invalid</returns>
        public async Task<string> Handle(EmployeeLoginDto request, CancellationToken cancellationToken)
        {
            Employee requestedEmployee = await _context.Employees
                .Include(e => e.Roles)
                .Include(e => e.Department)
                .Include(e => e.Department.Roles)
                .FirstOrDefaultAsync(e => string.Equals(request.Username, e.Username, StringComparison.InvariantCultureIgnoreCase));

            if (requestedEmployee == null)
            {
                _logger.LogWarning($"Failed login attempt with username: {request.Username}");

                return null;
            }

            if(!_hasher.PasswordMatches(request.Password, requestedEmployee.Password))
            {
                _logger.LogWarning($"Failed login attempt with username: {request.Username}");

                return null;
            }

            var rolesFromUser = requestedEmployee.Roles.Select(r => r.Role);
            var rolesFromDepartment = requestedEmployee.Department?.Roles?.Select(r => r?.Role);

            // add roles from employees department
            rolesFromUser = rolesFromDepartment != null && rolesFromDepartment.Count() > 0 ? rolesFromUser.Concat(rolesFromDepartment) : rolesFromUser; 

            return _tokenGenerator.CreateToken(requestedEmployee, rolesFromUser);
        }
    }
}
