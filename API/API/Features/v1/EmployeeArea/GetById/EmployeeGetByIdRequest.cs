using MediatR;
using System;

namespace CLERP.API.Features.v1.EmployeeArea.GetById
{
    public class EmployeeGetByIdRequest : IRequest<EmployeeResponse>
    {
        public Guid EmployeeId { get; set; }
    }
}
