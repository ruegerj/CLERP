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

namespace CLERP.API.Features.v1.RoleArea.GetAll
{
    public class RoleGetAllHandler : IRequestHandler<RoleGetAllRequest, RoleGetAllResponse>
    {
        private readonly ClerpContext _context;
        private readonly IMapper _mapper;

        public RoleGetAllHandler(ClerpContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<RoleGetAllResponse> Handle(RoleGetAllRequest request, CancellationToken cancellationToken)
        {
            var roleDtos = await _context.Roles.Select(r => new RoleResponse()
            {
                Guid = r.Guid,
                Description = r.Description,
                Name = r.Name
            }).ToListAsync(cancellationToken);

            return new RoleGetAllResponse() { Roles = roleDtos };
        }
    }
}
