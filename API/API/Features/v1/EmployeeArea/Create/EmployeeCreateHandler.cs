using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using CLERP.API.Infrastructure.Security.Hashing;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea.Create
{
    public class EmployeeCreateHandler : IRequestHandler<EmployeeCreateRequest, Guid>
    {
        private readonly ClerpContext _context;
        private readonly ILogger<EmployeeCreateHandler> _logger;
        private readonly IPasswordHasher _hasher;

        public EmployeeCreateHandler(
            ClerpContext context,
            ILogger<EmployeeCreateHandler> logger,
            IPasswordHasher hasher)
        {
            _context = context;
            _logger = logger;
            _hasher = hasher;
        }

        public async Task<Guid> Handle(EmployeeCreateRequest request, CancellationToken cancellationToken)
        {
            var employeesWithSimilarUsernameEmail = await _context.Employees
                .Where(e => e.Username == request.Username || e.Email == request.Email)
                .ToListAsync(cancellationToken);

            // check if username is available / unique
            if (employeesWithSimilarUsernameEmail.Any(e => e.Username == request.Username))
            {
                throw new ConflictException(nameof(request.Username), "Chosen username isn't available, please take another one.");
            }

            // check if email is available / unique
            if (employeesWithSimilarUsernameEmail.Any(e => e.Email == request.Email))
            {
                throw new ConflictException(nameof(request.Email), "Chosen email isn't available, please take another one.");
            }

            string hashedPassword = _hasher.HashPassword(request.Password);

            Employee newEmployee = new Employee()
            {
                Birthday = request.Birthday,
                Email = request.Email,
                Firstname = request.Firstname,
                Lastname = request.Lastname,
                PhoneNumber = request.PhoneNumber,
                Username = request.Username,
                Password = hashedPassword,
            };

            await _context.AddAsync(newEmployee, cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);

            _logger.LogDebug($"Successfully created user {newEmployee.Username} with the id {newEmployee.Guid}");

            return newEmployee.Guid;
        }
    }
}
