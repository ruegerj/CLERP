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

namespace CLERP.API.Features.v1.DepartmentArea.Update
{
    public class DepartmentUpdateHandler : IRequestHandler<DepartmentUpdateRequest, DepartmentResponse>
    {
        private readonly ClerpContext _context;
        private readonly IMapper _mapper;

        public DepartmentUpdateHandler(ClerpContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<DepartmentResponse> Handle(DepartmentUpdateRequest request, CancellationToken cancellationToken)
        {
            var department = await _context.Departments.FindByGuidAsync(request.DepartmentId, cancellationToken);

            if (department == null)
            {
                throw new BadRequestException(); // department to update not found
            }

            // Check if title of the department is unique
            if (_context.Departments.Where(d => d.Title == request.Title).Count() > 0)
            {
                throw new ConflictException(nameof(request.Title), $"A department with the title: {request.Title} already exists, please choose another name");
            }

            department.Title = request.Title;
            department.Description = request.Description;

            await _context.SaveChangesAsync(cancellationToken);

            return _mapper.Map<Department, DepartmentResponse>(department);
        }
    }
}
