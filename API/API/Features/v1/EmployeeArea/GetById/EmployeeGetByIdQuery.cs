using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CLERP.API.Features.v1.EmployeeArea.GetById
{
    public class EmployeeGetByIdQuery : IRequest<EmployeeDto>
    {
        public Guid EmployeeId { get; set; }
    }
}
