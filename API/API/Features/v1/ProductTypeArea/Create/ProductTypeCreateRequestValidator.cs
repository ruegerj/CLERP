using FluentValidation;

namespace CLERP.API.Features.v1.ProductTypeArea.Create
{
    public class ProductTypeCreateRequestValidator : AbstractValidator<ProductTypeCreateRequest>
    {
        private const int minNameLength = 2;
        private const int maxNameLength = 50;
        private const decimal minPrice = 0.01m;

        public ProductTypeCreateRequestValidator()
        {
            RuleFor(pt => pt.Name)
                .NotNull()
                .NotEmpty()
                .MinimumLength(minNameLength)
                .MaximumLength(maxNameLength);

            RuleFor(pt => pt.EAN)
                .NotNull()
                .NotEmpty();

            RuleFor(pt => pt.Price)
                .NotNull()
                .NotEmpty()
                .GreaterThan(minPrice);

            RuleFor(pt => pt.ChildGuids)
                .NotNull();

            RuleFor(pt => pt.ParentGuids)
                .NotNull();

            RuleForEach(pt => pt.ChildGuids).NotNull();

            RuleForEach(pt => pt.ParentGuids).NotNull();
        }
    }
}
