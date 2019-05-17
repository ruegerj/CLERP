using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.DepartmentArea.GetById
{
    public class DepartmentGetByIdRequest : IRequest<DepartmentResponse>
    {
        public Guid DepartmentId { get; set; }
    }
}
