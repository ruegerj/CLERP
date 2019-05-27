using MediatR;
using System;

namespace CLERP.API.Features.v1.DepartmentArea.GetById
{
    public class DepartmentGetByIdRequest : IRequest<DepartmentResponse>
    {
        public Guid DepartmentId { get; set; }
    }
}
