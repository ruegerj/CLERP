using FluentValidation;

namespace CLERP.API.Features.v1.RoleArea.Update
{
    public class RoleUpdateRequestValidator : AbstractValidator<RoleUpdateRequest>
    {
        public RoleUpdateRequestValidator()
        {
            RuleFor(r => r.Name)
                .NotNull()
                .NotEmpty()
                .MinimumLength(ValidationDefinitions.RoleNameMinCharCount)
                .MaximumLength(ValidationDefinitions.RoleNameMaxCharCount);
        }
    }
}
