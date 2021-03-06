﻿using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using CLERP.API.Infrastructure.Security.Hashing;
using CLERP.API.Infrastructure.Security.Tokens;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea.Login
{
    public class EmployeeLoginHandler : IRequestHandler<EmployeeLoginRequest, TokenResponse>
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
        public async Task<TokenResponse> Handle(EmployeeLoginRequest request, CancellationToken cancellationToken)
        {
            // Load only the needed data from employee for initial check (without roles etc)
            Employee requestedEmployee = await _context.Employees
                .Select(e => new Employee()
                {
                    Guid = e.Guid,
                    Username = e.Username,
                    Password = e.Password
                })
                .FirstOrDefaultAsync(e => string.Equals(request.Username, e.Username, StringComparison.InvariantCultureIgnoreCase), cancellationToken);

            if (requestedEmployee == null)
            {
                _logger.LogWarning($"Failed login attempt with username: {request.Username}");

                throw new BadRequestException("The provided username or password is invalid");
            }

            if (!_hasher.PasswordMatches(request.Password, requestedEmployee.Password))
            {
                _logger.LogWarning($"Failed login attempt with username: {request.Username}");

                throw new BadRequestException("The provided username or password is invalid");
            }

            // Reload the employee with all his roles (department and self asigned)
            requestedEmployee = _context.Employees
                .Include(e => e.Roles)
                    .ThenInclude(r => r.Role)
                .Include(e => e.Department)
                    .ThenInclude(d => d.Roles)
                        .ThenInclude(r => r.Role)
                .FirstOrDefault(e => e.Guid == requestedEmployee.Guid);

            var rolesFromUser = requestedEmployee.Roles.Select(r => r.Role);
            var rolesFromDepartment = requestedEmployee.Department?.Roles?.Select(r => r?.Role);

            // add roles from employees department
            rolesFromUser = rolesFromDepartment != null
                && rolesFromDepartment.Count() > 0 ? rolesFromUser.Concat(rolesFromDepartment) : rolesFromUser;

            var token = _tokenGenerator.CreateToken(requestedEmployee, rolesFromUser);

            return new TokenResponse()
            {
                Token = token
            };
        }
    }
}
