using AutoMapper;
using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductTypeArea.Create
{
    public class ProductTypeCreateHandler : IRequestHandler<ProductTypeCreateRequest, ProductTypeCreateResponse>
    {
        private readonly ClerpContext _context;
        private readonly IMapper _mapper;

        public ProductTypeCreateHandler(ClerpContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductTypeCreateResponse> Handle(ProductTypeCreateRequest request, CancellationToken cancellationToken)
        {
            // check if name is unique
            if (await _context.ProductTypes.Select(pt => pt.Name).AnyAsync(n => n == request.Name, cancellationToken))
            {
                throw new ConflictException(nameof(request.Name), $"A product type with the name: {request.Name} already exists, please choose another name");
            }

            var newProductType = _mapper.Map<ProductTypeCreateRequest, ProductType>(request);

            var children = await _context.ProductTypesProductTypes
                .Where(pt => request.ChildGuids.Contains(pt.ParentGuid))
                .ToListAsync(cancellationToken);

            children.ForEach(c => newProductType.Children.Add(c));

            var parents = await _context.ProductTypesProductTypes
                .Where(pt => request.ParentGuids.Contains(pt.ChildGuid))
                .ToListAsync(cancellationToken);

            parents.ForEach(p => newProductType.Parents.Add(p));

            await _context.SaveChangesAsync(cancellationToken);

            return new ProductTypeCreateResponse() { ProductTypeGuid = newProductType.Guid };
        }
    }
}
