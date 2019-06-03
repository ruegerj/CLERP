using AutoMapper;
using CLERP.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<Employee, EmployeeResponse>()
                .ForMember(e => e.Roles, t => t.Ignore());

            CreateMap<Department, EmployeeDepartmentResponse>();
        }
    }
}
