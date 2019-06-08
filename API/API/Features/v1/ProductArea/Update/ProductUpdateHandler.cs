using AutoMapper;
using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductArea.Update
{
    public class ProductUpdateHandler : IRequestHandler<ProductUpdateRequest, ProductResponse>
    {
        private readonly ClerpContext _context;
        private readonly IMapper _mapper;

        public ProductUpdateHandler(ClerpContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductResponse> Handle(ProductUpdateRequest request, CancellationToken cancellationToken)
        {
            var product = await _context.Products.FindByGuidAsync(request.ProductGuid, cancellationToken);

            if (product == null)
            {
                throw new BadRequestException(); // product to update couldn't be found => cant update product
            }

            product.Description = request.Description;
            product.State = request.State;
            product.CompartmentGuid = request.CompartmentGuid;

            await _context.SaveChangesAsync(cancellationToken);

            return _mapper.Map<ProductResponse>(product);
        }
    }
}
