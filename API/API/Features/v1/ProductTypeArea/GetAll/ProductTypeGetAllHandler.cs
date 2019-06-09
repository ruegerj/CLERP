using AutoMapper;
using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;
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
            var productTypes = await _context.ProductTypes.ToListAsync(cancellationToken);

            return new ProductTypeGetAllResponse() { ProductTypes = productTypes.Select(pt => _mapper.Map<ProductTypeResponse>(pt)) };
        }
    }
}
