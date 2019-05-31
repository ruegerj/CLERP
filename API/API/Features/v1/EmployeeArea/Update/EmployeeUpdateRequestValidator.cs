using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea.Update
{
    public class EmployeeUpdateRequestValidator : AbstractValidator<EmployeeUpdateRequest>
    {
        private const int minNameLength = 2;
        private const int maxNameLengt = 100;
        private const int maxAge = 100;
        private const int minAge = 18;
        private const int minPasswordLength = 10;
        private const int maxPasswordLength = 50;
        private const string phoneNumberRegex = @"^([\+][0-9]{1,3}([ \.\-])?)?([\(]{1}[0-9]{3}[\)])?([0-9A-Z \.\-]{1,32})((x|ext|extension)?[0-9]{1,4}?)$";

        public EmployeeUpdateRequestValidator()
        {
            RuleFor(e => e.Firstname)
                .NotNull()
                .NotEmpty()
                .MinimumLength(minNameLength)
                .MaximumLength(maxNameLengt);

            RuleFor(e => e.Lastname)
                .NotNull()
                .NotEmpty()
                .MinimumLength(minNameLength)
                .MaximumLength(maxNameLengt);

            RuleFor(e => e.Email)
                .NotNull()
                .NotEmpty()
                .EmailAddress();

            RuleFor(e => e.PhoneNumber)
                .NotNull()
                .NotEmpty()
                .Matches(new Regex(phoneNumberRegex)).WithMessage("The entered phone number is not valid.");

            RuleFor(e => e.Birthday)
                .NotNull()
                .Must(BeValidBirthday).WithMessage($"The new employee can't be younger than {minAge} years or older than {maxAge} years.");

            RuleFor(e => e.CurrentPassword)
                .NotNull()
                .NotEmpty()
                .When(e => !string.IsNullOrEmpty(e.NewPassword));

            RuleFor(e => e.CurrentPassword)
                .NotNull()
                .NotEmpty()
                .MinimumLength(minPasswordLength)
                .MaximumLength(maxPasswordLength)
                .Must(BeWithSpecialChars).WithMessage("The entered password must atleast contain one special character.")
                .When(e => !string.IsNullOrEmpty(e.CurrentPassword));
        }

        private static bool BeValidBirthday(DateTime birthday)
        {
            DateTime now = DateTime.Now;

            return birthday.AddYears(minAge) <= now
                && birthday.AddYears(maxAge) >= now;
        }

        private static bool BeWithSpecialChars(string value)
        {
            int specialCharsCount = value.Count(c => !char.IsLetterOrDigit(c));
            return specialCharsCount >= 1;
        }
    }
}
