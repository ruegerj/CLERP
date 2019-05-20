using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductTypeArea.Update
{
    public class ProductTypeUpdateRequestValidator : AbstractValidator<ProductTypeUpdateRequest>
    {
        private const int minNameLength = 2;
        private const int maxNameLength = 50;
        private const decimal minPrice = 0.01m;

        public ProductTypeUpdateRequestValidator()
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
        }
    }
}
