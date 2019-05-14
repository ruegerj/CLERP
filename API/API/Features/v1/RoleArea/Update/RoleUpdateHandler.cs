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

namespace CLERP.API.Features.v1.RoleArea.Update
{
    public class RoleUpdateHandler : IRequestHandler<RoleUpdateRequest, RoleResponse>
    {
        private readonly ClerpContext _context;
        private readonly IMapper _mapper;

        public RoleUpdateHandler(ClerpContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<RoleResponse> Handle(RoleUpdateRequest request, CancellationToken cancellationToken)
        {
            var role = await _context.Roles.FindAsync(request.RoleId, cancellationToken);

            if (role == null)
            {
                throw new BadRequestException(); // role to update not found
            }

            role.Name = request.Name;
            role.Description = request.Description;

            await _context.SaveChangesAsync(cancellationToken);

            return _mapper.Map<Role, RoleResponse>(role);
        }
    }
}
