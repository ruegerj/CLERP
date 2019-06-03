using FluentValidation;

namespace CLERP.API.Features.v1.ProductTypeArea.Update
{
    public class ProductTypeUpdateRequestValidator : AbstractValidator<ProductTypeUpdateRequest>
    {
        public ProductTypeUpdateRequestValidator()
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
        }
    }
}
