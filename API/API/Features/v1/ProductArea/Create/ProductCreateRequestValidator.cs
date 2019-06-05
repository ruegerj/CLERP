using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductArea.Create
{
    public class ProductCreateRequestValidator : AbstractValidator<ProductCreateRequest>
    {
        public ProductCreateRequestValidator()
        {       
            RuleForEach(p => p.ChildrenGuids)
                .NotNull()
                .NotEmpty()
                .When(p => p.ChildrenGuids != null && p.ChildrenGuids.Count() > 0);

            RuleFor(p => p.Description)
                .MaximumLength(ValidationDefinitions.ProductDescriptionMaxCharCount)
                .When(p => !string.IsNullOrEmpty(p.Description));

            RuleFor(p => p.SerialNumber)
                .NotNull()
                .NotEmpty()
                .MinimumLength(ValidationDefinitions.ProductSerialNumberMinCharCount)
                .MaximumLength(ValidationDefinitions.ProductSerialNumberMaxCharCount);
        }

        private bool ChildGuidsExisting(IEnumerable<Guid> childGuids)
        {
            return childGuids != null && childGuids.Count() > 0;
        }
    }
}
