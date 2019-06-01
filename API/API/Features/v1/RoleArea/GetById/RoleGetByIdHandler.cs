using AutoMapper;
using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Contexts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.RoleArea.GetById
{
    public class RoleGetByIdHandler : IRequestHandler<RoleGetByIdRequest, RoleResponse>
    {
        private readonly ClerpContext _context;
        private readonly IMapper _mapper;

        public RoleGetByIdHandler(ClerpContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<RoleResponse> Handle(RoleGetByIdRequest request, CancellationToken cancellationToken)
        {
            var role = await _context.Roles.FindByGuidAsync(request.RoleId, cancellationToken);

            if (role == null)
            {
                return null;
            }

            return _mapper.Map<Role, RoleResponse>(role);
        }
    }
}
