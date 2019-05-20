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

namespace CLERP.API.Features.v1.ProductTypeArea.GetById
{
    public class ProductTypeGetByIdHandler : IRequestHandler<ProductTypeGetByIdRequest, ProductTypeResponse>
    {
        private readonly ClerpContext _context;
        private readonly IMapper _mapper;

        public ProductTypeGetByIdHandler(ClerpContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductTypeResponse> Handle(ProductTypeGetByIdRequest request, CancellationToken cancellationToken)
        {
            var productType = await _context.ProductTypes
                .Include(pt => pt.Children)
                .Include(pt => pt.Parents)
                .FirstOrDefaultAsync(pt => pt.Guid == request.ProductTypeId, cancellationToken);

            if (productType == null)
            {
                return null;
            }

            var productTypeDto = _mapper.Map<ProductType, ProductTypeResponse>(productType);

            productTypeDto.ChildGuids = productType.Children.Select(ptc => ptc.ChildGuid);
            productTypeDto.ParentGuids = productType.Parents.Select(ptp => ptp.ParentGuid);

            return productTypeDto;
        }
    }
}
