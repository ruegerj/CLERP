using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using CLERP.API.Infrastructure.Security.Hashing;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea.Create
{
    public class Handler : IRequestHandler<Command, Guid>
    {
        private readonly ClerpContext _context;
        private readonly ILogger<Handler> _logger;
        private readonly IPasswordHasher _hasher;

        public Handler(
            ClerpContext context,
            ILogger<Handler> logger,
            IPasswordHasher hasher)
        {
            _context = context;
            _logger = logger;
            _hasher = hasher;
        }

        public async Task<Guid> Handle(Command request, CancellationToken cancellationToken)
        {
            // check if username is available / unique
            if (await _context.Employees
                .Where(e => String.Equals(request.EmployeeData.Username, e.Username, StringComparison.InvariantCultureIgnoreCase))
                .AnyAsync(cancellationToken))
            {
                throw new ConflictException(nameof(request.EmployeeData.Username), "Chosen username isn't available, please take another one.");
            }

            // check if email is available / unique
            if (await _context.Employees
                .Where(e => String.Equals(request.EmployeeData.Email, e.Email, StringComparison.InvariantCultureIgnoreCase))
                .AnyAsync(cancellationToken))
            {
                throw new ConflictException(nameof(request.EmployeeData.Email), "Chosen email isn't available, please take another one.");
            }

            IHashedPassword hashInfo = _hasher.HashPassword(request.EmployeeData.Password);

            Employee newEmployee = new Employee()
            {
                Firstname = request.EmployeeData.Firstname,
                Lastname = request.EmployeeData.Lastname,
                Birthday = request.EmployeeData.Birthday,
                Email = request.EmployeeData.Email,
                Username = request.EmployeeData.Username,
                PhoneNumber = request.EmployeeData.PhoneNumber,
                Password = hashInfo.HashBase64,
                Salt = hashInfo.SaltBase64
            };

            await _context.AddAsync(newEmployee, cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);

            _logger.LogDebug($"Successfully created user {newEmployee.Username} with the id {newEmployee.Guid}");

            return newEmployee.Guid;
        }
    }
}
