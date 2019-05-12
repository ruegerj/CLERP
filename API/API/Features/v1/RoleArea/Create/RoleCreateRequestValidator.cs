using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.RoleArea.Create
{
    public class RoleCreateRequestValidator : AbstractValidator<RoleCreateRequest>
    {
        private const int minNameLength = 2;
        private const int maxNameLength = 30;

        public RoleCreateRequestValidator()
        {
            RuleFor(r => r.Name)
                .NotNull()
                .NotEmpty()
                .MinimumLength(minNameLength)
                .MaximumLength(maxNameLength);
        }
    }
}
