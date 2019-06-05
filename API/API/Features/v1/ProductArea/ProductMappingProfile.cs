using AutoMapper;
using CLERP.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.ProductArea
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, ProductResponse>()
                .ForMember(p => p.ChildrenGuids, opt => opt.Ignore());
        }
    }
}
