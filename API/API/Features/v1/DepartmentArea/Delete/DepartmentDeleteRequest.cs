using MediatR;
using System;

namespace CLERP.API.Features.v1.DepartmentArea.Delete
{
    public class DepartmentDeleteRequest : IRequest
    {
        public Guid RoleId { get; set; }
    }
}
