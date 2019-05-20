using AutoMapper;
using CLERP.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        }
    }
}
