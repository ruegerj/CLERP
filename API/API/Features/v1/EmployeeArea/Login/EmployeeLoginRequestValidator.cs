using FluentValidation;

namespace CLERP.API.Features.v1.EmployeeArea.Login
{
    public class EmployeeLoginRequestValidator : AbstractValidator<EmployeeLoginRequest>
    {
        public EmployeeLoginRequestValidator()
        {
            RuleFor(eld => eld.Username)
                .NotNull()
                .NotEmpty()
                .MaximumLength(ValidationDefinitions.EmployeeUsernameMaxCharCount);

            RuleFor(eld => eld.Password)
                .NotNull()
                .NotEmpty()
                .MaximumLength(ValidationDefinitions.EmployeePasswordMaxCharCount);
        }
    }
}
