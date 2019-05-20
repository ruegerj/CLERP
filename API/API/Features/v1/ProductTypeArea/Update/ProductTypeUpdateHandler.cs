
using AutoMapper;
using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductTypeArea.Update
{
    public class ProductTypeUpdateHandler : IRequestHandler<ProductTypeUpdateRequest, ProductTypeResponse>
    {
        private readonly ClerpContext _context;
        private readonly IMapper _mapper;

        public ProductTypeUpdateHandler(ClerpContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductTypeResponse> Handle(ProductTypeUpdateRequest request, CancellationToken cancellationToken)
        {
            // check if name is unique
            if (await _context.ProductTypes.Select(pt => pt.Name).AnyAsync(n => n == request.Name, cancellationToken))
            {
                throw new ConflictException(nameof(request.Name), $"A product type with the name: {request.Name} already exists, please choose another name");
            }

            var productType = await _context.ProductTypes
                .Include(pt => pt.Children)
                .Include(pt => pt.Parents)
                .FirstOrDefaultAsync(pt => pt.Guid == request.ProductTypeGuid, cancellationToken);

            if (productType == null)
            {
                throw new BadRequestException(); // product type to update not found
            }

            productType.Name = request.Name;
            productType.Description = request.Description;
            productType.EAN = request.EAN;
            productType.Price = request.Price;

            await _context.SaveChangesAsync(cancellationToken);

            var updatedProductTypeDto = _mapper.Map<ProductType, ProductTypeResponse>(productType);

            updatedProductTypeDto.ChildGuids = productType.Children.Select(ptc => ptc.ChildGuid);
            updatedProductTypeDto.ParentGuids = productType.Parents.Select(ptp => ptp.ParentGuid);

            return updatedProductTypeDto;
        }
    }
}
