using FluentValidation;

namespace CLERP.API.Features.v1.ProductTypeArea.Create
{
    public class ProductTypeCreateRequestValidator : AbstractValidator<ProductTypeCreateRequest>
    {
        public ProductTypeCreateRequestValidator()
        {
            RuleFor(pt => pt.Name)
                .NotNull()
                .NotEmpty()
                .MinimumLength(ValidationDefinitions.ProductTypeNameMinCharCount)
                .MaximumLength(ValidationDefinitions.ProductTypeNameMaxCharCount);

            RuleFor(pt => pt.EAN)
                .NotNull()
                .NotEmpty();

            RuleFor(pt => pt.Price)
                .NotNull()
                .NotEmpty()
                .GreaterThan(ValidationDefinitions.ProductTypePriceMin);

            RuleFor(pt => pt.Image)
                .Must(ValidationDefinitions.BeBase64)
                .When(pt => !string.IsNullOrEmpty(pt.Image));
        }
    }
}
