using AutoMapper;
using CLERP.API.Infrastructure.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductArea.GetById
{
    public class ProductGetByIdHandler : IRequestHandler<ProductGetByIdRequest, ProductResponse>
    {
        private readonly ClerpContext _context;
        private readonly IMapper _mapper;

        public ProductGetByIdHandler(ClerpContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductResponse> Handle(ProductGetByIdRequest request, CancellationToken cancellationToken)
        {
            var product = await _context.Products
                .Include(p => p.Children)
                .FirstOrDefaultAsync(p => p.Guid == request.ProductId, cancellationToken);

            if (product == null)
            {
                return null;
            }

            var productDto = _mapper.Map<ProductResponse>(product);

            productDto.ChildrenGuids = product.Children.Select(c => c.Guid);

            return productDto;
        }
    }
}
