using AutoMapper;
using CLERP.API.Domain.Models;
using CLERP.API.Domain.Models.Abstract;
using CLERP.API.Infrastructure.Contexts;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductArea.Create
{
    public class ProductCreateHandler : IRequestHandler<ProductCreateRequest, ProductCreateResponse>
    {
        private readonly ClerpContext _context;
        private readonly IMapper _mapper;

        public ProductCreateHandler(ClerpContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductCreateResponse> Handle(ProductCreateRequest request, CancellationToken cancellationToken)
        {
            var responseData = new List<ProductCreateResponseModel>();

            foreach (var productModel in request.Products)
            {
                var product = new Product()
                {
                    Description = productModel.Description,
                    SerialNumber = productModel.SerialNumber,
                    State = ProductState.InStock
                };

                product.Type = await _context.ProductTypes.FindByGuidAsync(productModel.TypeGuid, cancellationToken);

                if (product.Type == null)
                {
                    throw new BadRequestException(); // cant create product => product type not found
                }

                product.Compartment = await _context.Compartments.FindByGuidAsync(productModel.CompartmentGuid, cancellationToken);

                if (product.Compartment == null)
                {
                    throw new BadRequestException(); // cant create product => compartment not found
                }

                var parentProduct = productModel.ParentGuid != null ? 
                    await _context.Products.FindByGuidAsync(new Guid(productModel.ParentGuid.ToString()), cancellationToken) : null;

                if (parentProduct != null) // only add parent if found or parent id is not null
                {
                    product.Parent = parentProduct;
                }

                // add child products if existing
                if (productModel.ChildrenGuids != null && productModel.ChildrenGuids.Any())
                {
                    foreach (var childGuid in productModel.ChildrenGuids)
                    {
                        var child = await _context.Products.FindByGuidAsync(childGuid, cancellationToken);

                        if (child != null)
                        {
                            product.Children.Add(child);
                        }
                    }
                }

                await _context.Products.AddAsync(product, cancellationToken);

                responseData.Add(new ProductCreateResponseModel()
                {
                    ProductGuid = product.Guid,
                    SerialNumber = product.SerialNumber
                });
            }

            await _context.SaveChangesAsync(cancellationToken);

            return new ProductCreateResponse() { Products =  responseData };
        }
    }
}
