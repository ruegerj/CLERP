using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea.Create
{
    public class EmployeeCreateRequestValidator : AbstractValidator<EmployeeCreateRequest>
    {
        private const int minNameLength = 2;
        private const int maxNameLengt = 100;
        private const int minUsernameLength = 5;
        private const int maxUsernameLength = 15;
        private const int minPasswordLength = 10;
        private const int maxPasswordLength = 50;
        private const int maxAge = 100;
        private const int minAge = 18;

        public EmployeeCreateRequestValidator()
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
                .Must(BePhoneNumber).WithMessage("The entered phone number is not valid.");

            RuleFor(e => e.Birthday)
                .NotNull()
                .Must(BeValidBirthday).WithMessage($"The new employee can't be younger than {minAge} years or older than {maxAge} years.");

            RuleFor(e => e.Username)
                .NotNull()
                .NotEmpty()
                .MinimumLength(minUsernameLength)
                .MaximumLength(maxUsernameLength)
                .Must(BeWhiteSpaceless).WithMessage("The username cannot contain any whitespaces.")
                .Must(BeWithoutSpecialChars).WithMessage("The username cannot contain any special characters.");

            RuleFor(e => e.Password)
                .NotNull()
                .NotEmpty()
                .MinimumLength(minPasswordLength)
                .MaximumLength(maxPasswordLength)
                .Must(BeWithSpecialChars).WithMessage("The entered password must atleast contain one special character.");
        }

        private static bool BePhoneNumber(string phoneNumber)
        {
            // Regex for international phone numbers
            const string expression = @"\+(9[976]\d|8[987530]\d|6[987]\d|5[90]\d|42\d|3[875]\d|2[98654321]\d|9[8543210]|8[6421]|6[6543210]|5[87654321]|4[987654310]|3[9643210]|2[70]|7|1)\d{1,14}$";
            return Regex.Match(phoneNumber, expression).Success;
        }

        private static bool BeValidBirthday(DateTime birthday)
        {
            DateTime now = DateTime.Now;

            return birthday.AddYears(minAge) <= now
                && birthday.AddYears(maxAge) >= now;
        }

        private static bool BeWhiteSpaceless(string value)
        {
            return !value.Contains(" ");
        }

        private static bool BeWithoutSpecialChars(string value)
        {
            const string expression = @"(?i)^[a-z’'()/.,\s-]+$";
            return Regex.Match(value, expression).Success;
        }

        private static bool BeWithSpecialChars(string value)
        {
            int specialCharsCount = value.Count(c => !char.IsLetterOrDigit(c));
            return specialCharsCount >= 1;
        }
    }
}
