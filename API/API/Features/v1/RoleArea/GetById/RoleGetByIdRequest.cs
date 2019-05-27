using MediatR;
using System;

namespace CLERP.API.Features.v1.RoleArea.GetById
{
    public class RoleGetByIdRequest : IRequest<RoleResponse>
    {
        public Guid RoleId { get; set; }
    }
}
