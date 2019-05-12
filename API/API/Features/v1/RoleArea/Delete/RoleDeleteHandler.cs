using CLERP.API.Infrastructure.Contexts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.RoleArea.Delete
{
    public class RoleDeleteHandler : IRequestHandler<RoleDeleteRequest, bool>
    {
        private readonly ClerpContext _context;

        public RoleDeleteHandler(ClerpContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(RoleDeleteRequest request, CancellationToken cancellationToken)
        {
            var roleToDelete = await _context.Roles.FindAsync(request.RoleId, cancellationToken);

            if (roleToDelete == null) // Role not found
            {
                return false;
            }

            _context.Roles.Remove(roleToDelete);

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
