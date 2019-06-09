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

namespace CLERP.API.Features.v1.ProductTypeArea.GetAllChildren
{
    public class ProductTypeGetAllChildrenHandler : IRequestHandler<ProductTypeGetAllChildrenRequest, ProductTypeGetAllChildrenResponse>
    {
        private readonly ClerpContext _context;
        private readonly IMapper _mapper;

        public ProductTypeGetAllChildrenHandler(ClerpContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductTypeGetAllChildrenResponse> Handle(ProductTypeGetAllChildrenRequest request, CancellationToken cancellationToken)
        {
            var children = await _context.ProductTypes
                        .Include(pt => pt.Parents)
                        .Where(pt => pt.Parents.Any(p => p.ParentGuid == request.ParentGuid))
                        .ToListAsync(cancellationToken);

            return new ProductTypeGetAllChildrenResponse()
            {
                Children = children.Select(c => _mapper.Map<ProductTypeResponse>(c))
            };
        }
    }
}
