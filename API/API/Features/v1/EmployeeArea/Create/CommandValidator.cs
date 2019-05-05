using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea.Create
{
    public class CommandValidator : AbstractValidator<Command>
    {
        public CommandValidator()
        {
            RuleFor(c => c.EmployeeData).NotNull().SetValidator(new EmployeeCreateDtoValidator());
        }
    }
}
