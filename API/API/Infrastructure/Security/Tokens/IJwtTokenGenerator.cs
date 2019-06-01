using CLERP.API.Domain.Models;
using System.Collections.Generic;

namespace CLERP.API.Infrastructure.Security.Tokens
{
    public interface IJwtTokenGenerator
    {
        string CreateToken(Employee employee, IEnumerable<Role> roles);
    }
}
