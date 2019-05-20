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

namespace CLERP.API.Features.v1.ProductTypeArea.GetAll
{
    public class ProductTypeGetAllHandler : IRequestHandler<ProductTypeGetAllRequest, ProductTypeGetAllResponse>
    {
        private readonly ClerpContext _context;
        private readonly IMapper _mapper;

        public ProductTypeGetAllHandler(ClerpContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductTypeGetAllResponse> Handle(ProductTypeGetAllRequest request, CancellationToken cancellationToken)
        {
            var productTypes = await _context.ProductTypes
                .Include(pt => pt.Children)
                .Include(pt => pt.Parents).ToListAsync(cancellationToken);

            var productTypeDtos = productTypes.Select(pt =>
            {
                var productTypeDto = _mapper.Map<ProductType, ProductTypeResponse>(pt);

                // Fill parent and child id collections
                productTypeDto.ChildGuids = pt.Children.Select(c => c.ChildGuid);
                productTypeDto.ParentGuids = pt.Parents.Select(p => p.ParentGuid);

                return productTypeDto;
            });

            return new ProductTypeGetAllResponse() { ProductTypes = productTypeDtos };
        }
    }
}
