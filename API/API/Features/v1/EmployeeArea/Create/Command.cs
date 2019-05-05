using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea.Create
{
    public class Command : IRequest<Guid>
    {
        public EmployeeCreateDto EmployeeData { get; set; }
    }
}
