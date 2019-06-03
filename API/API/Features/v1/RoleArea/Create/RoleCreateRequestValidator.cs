using FluentValidation;

namespace CLERP.API.Features.v1.RoleArea.Create
{
    public class RoleCreateRequestValidator : AbstractValidator<RoleCreateRequest>
    {
        public RoleCreateRequestValidator()
        {
            RuleFor(r => r.Name)
                .NotNull()
                .NotEmpty()
                .MinimumLength(ValidationDefinitions.RoleNameMinCharCount)
                .MaximumLength(ValidationDefinitions.RoleNameMaxCharCount);
        }
    }
}
