using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductArea.Update
{
    public class ProductUpdateRequestHandler : AbstractValidator<ProductUpdateRequest>
    {
        public ProductUpdateRequestHandler()
        {
            RuleFor(p => p.State)
                .NotNull()
                .NotEmpty();

            RuleFor(p => p.CompartmentGuid)
                .NotNull();
        }
    }
}
