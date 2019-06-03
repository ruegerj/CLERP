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

            RuleFor(pt => pt.ChildGuids)
                .NotNull();

            RuleFor(pt => pt.ParentGuids)
                .NotNull();

            RuleForEach(pt => pt.ChildGuids).NotNull();

            RuleForEach(pt => pt.ParentGuids).NotNull();
        }
    }
}
