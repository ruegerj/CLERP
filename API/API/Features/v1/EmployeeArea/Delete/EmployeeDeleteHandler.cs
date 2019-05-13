﻿using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea.Delete
{
    public class EmployeeDeleteHandler : AsyncRequestHandler<EmployeeDeleteRequest>
    {
        private readonly ClerpContext _context;

        public EmployeeDeleteHandler(ClerpContext context)
        {
            _context = context;
        }

        protected async override Task Handle(EmployeeDeleteRequest request, CancellationToken cancellationToken)
        {
            var employee = await _context.Employees.FindAsync(request.EmployeeId, cancellationToken);

            if (employee == null)
            {
                throw new BadRequestException("Something went wrong, please try it again"); // employee to delete not found
            }

            _context.Employees.Remove(employee);

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
