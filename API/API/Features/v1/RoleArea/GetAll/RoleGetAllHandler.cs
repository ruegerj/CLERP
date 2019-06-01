using AutoMapper;
using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;
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
            var roleDtos = await _context.Roles.Select(r => _mapper.Map<Role, RoleResponse>(r)).ToListAsync(cancellationToken);

            return new RoleGetAllResponse() { Roles = roleDtos };
        }
    }
}
