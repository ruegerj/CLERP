using FluentValidation;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CLERP.API.Features.v1.EmployeeArea.Create
{
    public class EmployeeCreateRequestValidator : AbstractValidator<EmployeeCreateRequest>
    {
        public EmployeeCreateRequestValidator()
        {
            RuleFor(e => e.Firstname)
                .NotNull()
                .NotEmpty()
                .MinimumLength(ValidationDefinitions.EmployeeNameMinCharCount)
                .MaximumLength(ValidationDefinitions.EmployeeNameMaxCharCount);

            RuleFor(e => e.Lastname)
                .NotNull()
                .NotEmpty()
                .MinimumLength(ValidationDefinitions.EmployeeNameMinCharCount)
                .MaximumLength(ValidationDefinitions.EmployeeNameMaxCharCount);

            RuleFor(e => e.Email)
                .NotNull()
                .NotEmpty()
                .EmailAddress();

            RuleFor(e => e.PhoneNumber)
                .NotNull()
                .NotEmpty()
                .Must(ValidationDefinitions.BePhoneNumber).WithMessage("The entered phone number is not valid.");

            RuleFor(e => e.Birthday)
                .NotNull()
                .Must(ValidationDefinitions.BeValidBirthday).WithMessage($"The new employee can't be younger than {ValidationDefinitions.EmployeeAgeMaxYears} years or older than {ValidationDefinitions.EmployeeAgeMinYears} years.");

            RuleFor(e => e.Username)
                .NotNull()
                .NotEmpty()
                .MinimumLength(ValidationDefinitions.EmployeeUsernameMinCharCount)
                .MaximumLength(ValidationDefinitions.EmployeeUsernameMaxCharCount)
                .Must(ValidationDefinitions.BeWhiteSpaceless).WithMessage("The username cannot contain any whitespaces.")
                .Must(ValidationDefinitions.BeWithoutSpecialChars).WithMessage("The username cannot contain any special characters.");

            RuleFor(e => e.Password)
                .NotNull()
                .NotEmpty()
                .MinimumLength(ValidationDefinitions.EmployeePasswordMinCharCount)
                .MaximumLength(ValidationDefinitions.EmployeePasswordMaxCharCount)
                .Must(ValidationDefinitions.BeWithSpecialChars).WithMessage("The entered password must atleast contain one special character.");
        }
    }
}
