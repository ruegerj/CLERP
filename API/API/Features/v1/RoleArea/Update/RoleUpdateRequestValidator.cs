using FluentValidation;

namespace CLERP.API.Features.v1.RoleArea.Update
{
    public class RoleUpdateRequestValidator : AbstractValidator<RoleUpdateRequest>
    {
        private const int minNameLength = 2;
        private const int maxNameLength = 30;

        public RoleUpdateRequestValidator()
        {
            RuleFor(r => r.Name)
                .NotNull()
                .NotEmpty()
                .MinimumLength(minNameLength)
                .MaximumLength(maxNameLength);
        }
    }
}
