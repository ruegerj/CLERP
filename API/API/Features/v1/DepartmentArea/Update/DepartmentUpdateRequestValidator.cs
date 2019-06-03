using FluentValidation;

namespace CLERP.API.Features.v1.DepartmentArea.Update
{
    public class DepartmentUpdateRequestValidator : AbstractValidator<DepartmentUpdateRequest>
    {
        public DepartmentUpdateRequestValidator()
        {
            RuleFor(d => d.Title)
                .NotNull()
                .NotEmpty()
                .MinimumLength(ValidationDefinitions.DepartmentTitleMinCharCount)
                .MaximumLength(ValidationDefinitions.DepartmentTitleMaxCharCount);
        }
    }
}
