using AutoMapper;
using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductArea.GetAll
{
    public class ProductGetAllHandler : IRequestHandler<ProductGetAllRequest, ProductGetAllResponse>
    {
        private readonly ClerpContext _context;
        private readonly IMapper _mapper;

        public ProductGetAllHandler(ClerpContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductGetAllResponse> Handle(ProductGetAllRequest request, CancellationToken cancellationToken)
        {
            var products = await _context.Products.Include(p => p.Children).ToListAsync(cancellationToken);

            var productDtos = products.Select(p =>
            {
                var productDto = _mapper.Map<Product, ProductResponse>(p);

                productDto.ChildrenGuids = p.Children.Select(c => c.Guid);

                return productDto;
            });

            return new ProductGetAllResponse() { Products = productDtos };
        }
    }
}
