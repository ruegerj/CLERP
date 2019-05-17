using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.DepartmentArea.Delete
{
    public class DepartmentDeleteRequest : IRequest
    {
        public Guid RoleId { get; set; }
    }
}
