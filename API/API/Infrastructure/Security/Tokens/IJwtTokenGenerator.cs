using CLERP.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Security.Tokens
{
    public interface IJwtTokenGenerator
    {
        string CreateToken(Employee employee, IEnumerable<Role> roles);
    }
}
