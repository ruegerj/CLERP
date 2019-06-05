using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1
{
    /// <summary>
    /// Class which contains all definitions and predicates used in the validators
    /// </summary>
    public static class ValidationDefinitions
    {
        #region Constants

        public const int DepartmentTitleMinCharCount = 2;

        public const int DepartmentTitleMaxCharCount = 30;

        public const int EmployeeNameMinCharCount = 2;

        public const int EmployeeNameMaxCharCount = 100;

        public const int EmployeeUsernameMinCharCount = 5;

        public const int EmployeeUsernameMaxCharCount = 15;

        public const int EmployeePasswordMinCharCount = 10;

        public const int EmployeePasswordMaxCharCount = 50;

        public const int EmployeeAgeMinYears = 15;

        public const int EmployeeAgeMaxYears = 100;

        public const int ProductTypeNameMinCharCount = 2;

        public const int ProductTypeNameMaxCharCount = 50;

        public const decimal ProductTypePriceMin = 0.01m;

        public const int RoleNameMinCharCount = 2;

        public const int RoleNameMaxCharCount = 30;

        public const int ProductDescriptionMaxCharCount = 500;

        public const int ProductSerialNumberMinCharCount = 4;

        public const int ProductSerialNumberMaxCharCount = 30;

        public const int ProductMaxChildCount = 50;

        #endregion

        #region Predicates

        public static bool BePhoneNumber(string phoneNumber)
        {
            // Regex for international phone numbers
            const string expression = @"^([\+][0-9]{1,3}([ \.\-])?)?([\(]{1}[0-9]{3}[\)])?([0-9A-Z \.\-]{1,32})((x|ext|extension)?[0-9]{1,4}?)$";
            return Regex.Match(phoneNumber, expression).Success;
        }

        public static bool BeValidBirthday(DateTime birthday)
        {
            DateTime now = DateTime.Now;

            return birthday.AddYears(EmployeeAgeMinYears) <= now
                && birthday.AddYears(EmployeeAgeMaxYears) >= now;
        }

        public static bool BeWhiteSpaceless(string value)
        {
            return !value.Contains(" ");
        }

        public static bool BeWithoutSpecialChars(string value)
        {
            const string expression = @"(?i)^[a-z’'()/.,\s-]+$";
            return Regex.Match(value, expression).Success;
        }

        public static bool BeWithSpecialChars(string value)
        {
            int specialCharsCount = value.Count(c => !char.IsLetterOrDigit(c));
            return specialCharsCount >= 1;
        }

        #endregion
    }
}
