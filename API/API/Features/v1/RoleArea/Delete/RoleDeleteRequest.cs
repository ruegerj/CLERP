using MediatR;
using System;

namespace CLERP.API.Features.v1.RoleArea.Delete
{
    public class RoleDeleteRequest : IRequest
    {
        public Guid RoleId { get; set; }
    }
}
