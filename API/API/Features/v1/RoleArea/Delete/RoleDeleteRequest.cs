using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.RoleArea.Delete
{
    public class RoleDeleteRequest : IRequest<bool>
    {
        public Guid RoleId { get; set; }
    }
}
