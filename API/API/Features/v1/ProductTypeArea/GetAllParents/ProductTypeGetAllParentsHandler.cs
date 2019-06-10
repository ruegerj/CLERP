using AutoMapper;
using CLERP.API.Infrastructure.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductTypeArea.GetAllParents
{
    public class ProductTypeGetAllParentsHandler : IRequestHandler<ProductTypeGetAllParentsRequest, ProductTypeGetAllParentsResponse>
    {
        private readonly ClerpContext _context;
        private readonly IMapper _mapper;

        public ProductTypeGetAllParentsHandler(ClerpContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductTypeGetAllParentsResponse> Handle(ProductTypeGetAllParentsRequest request, CancellationToken cancellationToken)
        {
            var parents = await _context.ProductTypes
                            .Include(pt => pt.Children)
                            .Where(pt => pt.Children.Any(c => c.ChildGuid == request.ChildId))
                            .ToListAsync(cancellationToken);

            return new ProductTypeGetAllParentsResponse()
            {
                Parents = parents.Select(p => _mapper.Map<ProductTypeResponse>(p))
            };
        }
    }
}
