using AutoMapper;
using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.DepartmentArea.Create
{
    public class DepartmentCreateHandler : IRequestHandler<DepartmentCreateRequest, DepartmentCreateResponse>
    {
        private readonly ClerpContext _context;
        private readonly IMapper _mapper; 

        public DepartmentCreateHandler(ClerpContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<DepartmentCreateResponse> Handle(DepartmentCreateRequest request, CancellationToken cancellationToken)
        {
            // Check if title of the department is unique
            if (_context.Departments.Where(d => d.Title == request.Title).Count() > 0)
            {
                throw new ConflictException(nameof(request.Title), $"A department with the title: {request.Title} already exists, please choose another name");
            }

            var newDepartment = _mapper.Map<DepartmentCreateRequest, Department>(request);

            await _context.Departments.AddAsync(newDepartment, cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);

            return new DepartmentCreateResponse() { DepartmentId = newDepartment.Guid };
        }
    }
}
