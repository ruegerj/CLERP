using AutoMapper;
using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.DepartmentArea.GetAll
{
    public class DepartmentGetAllHandler : IRequestHandler<DepartmentGetAllRequest, DepartmentGetAllResponse>
    {
        private readonly ClerpContext _context;
        private readonly IMapper _mapper;

        public DepartmentGetAllHandler(ClerpContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<DepartmentGetAllResponse> Handle(DepartmentGetAllRequest request, CancellationToken cancellationToken)
        {
            var departmentDtos = await _context.Departments.Select(d => _mapper.Map<Department, DepartmentResponse>(d)).ToListAsync(cancellationToken);

            return new DepartmentGetAllResponse() { Deparments = departmentDtos };
        }
    }
}
