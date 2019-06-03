using FluentValidation;

namespace CLERP.API.Features.v1.DepartmentArea.Create
{
    public class DepartmentCreateRequestValidator : AbstractValidator<DepartmentCreateRequest>
    {
        public DepartmentCreateRequestValidator()
        {
            RuleFor(d => d.Title)
                .NotNull()
                .NotEmpty()
                .MinimumLength(ValidationDefinitions.DepartmentTitleMinCharCount)
                .MaximumLength(ValidationDefinitions.DepartmentTitleMaxCharCount);
        }
    }
}
