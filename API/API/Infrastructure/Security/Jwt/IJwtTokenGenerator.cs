using CLERP.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Security.Jwt
{
    public interface IJwtTokenGenerator
    {
        string CreateToken(Employee employee, IEnumerable<Role> roles);
    }
}
