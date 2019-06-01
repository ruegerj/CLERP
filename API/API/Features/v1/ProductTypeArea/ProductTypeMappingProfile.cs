using AutoMapper;
using CLERP.API.Domain.Models;

namespace CLERP.API.Features.v1.ProductTypeArea
{
    public class ProductTypeMappingProfile : Profile
    {
        public ProductTypeMappingProfile()
        {
            // Map which ignores the guid-collections for children and parents
            CreateMap<ProductType, ProductTypeResponse>()
                .ForMember(pt => pt.ParentGuids, t => t.Ignore())
                .ForMember(pt => pt.ChildGuids, t => t.Ignore());

            CreateMap<Create.ProductTypeCreateRequest, ProductType>()
                .ForMember(pt => pt.Children, t => t.Ignore())
                .ForMember(pt => pt.Parents, t => t.Ignore());
        }
    }
}
