using AutoMapper;
using CLERP.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.WarehouseArea
{
    public class WarehouseMappingProfile : Profile
    {
        public WarehouseMappingProfile()
        {
            CreateMap<Warehouse, WarehouseResponse>()
                .ForMember(w => w.Shelves, opt => opt.Ignore());

            CreateMap<Country, WarehouseCountryResponse>();
            CreateMap<City, WarehouseCityResponse>();
            CreateMap<Address, WarehouseAddressResponse>();
            CreateMap<Shelf, WarehouseShelfResponse>()
                .ForMember(s => s.Compartments, opt => opt.Ignore());
            CreateMap<Compartment, WarehouseCompartmentResponse>();
        }
    }
}
