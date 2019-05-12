using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.RoleArea.GetById
{
    public class RoleGetByIdRequest : IRequest<RoleResponse>
    {
        public Guid RoleId { get; set; }
    }
}
