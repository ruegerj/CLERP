using AutoMapper;
using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.RoleArea.Create
{
    public class RoleCreateHandler : IRequestHandler<RoleCreateRequest, RoleCreateResponse>
    {
        private readonly ClerpContext _context;
        private readonly IMapper _mapper;

        public RoleCreateHandler(ClerpContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<RoleCreateResponse> Handle(RoleCreateRequest request, CancellationToken cancellationToken)
        {
            // Check if name of the role is unique
            if (_context.Roles.Where(r => r.Name == request.Name).Count() > 0)
            {
                throw new ConflictException(nameof(request.Name), $"A role with the name: {request.Name} already exists, please choose another name");
            }

            var newRole = _mapper.Map<RoleCreateRequest, Role>(request);

            await _context.Roles.AddAsync(newRole, cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);

            return new RoleCreateResponse() { RoleId = newRole.Guid };
        }
    }
}
