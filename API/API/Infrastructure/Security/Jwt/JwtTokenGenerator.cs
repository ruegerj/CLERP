using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CLERP.API.Domain.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace CLERP.API.Infrastructure.Security.Jwt
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly JwtOptions _jwtOptions;

        public JwtTokenGenerator(IOptions<JwtOptions> jwtOptions)
        {
            _jwtOptions = jwtOptions.Value;
        }

        /// <summary>
        /// Creates a new Jwt-Token  for an employee/user with the required data of him and his roles
        /// </summary>
        /// <param name="employee">Employee th token should be issued for</param>
        /// <param name="roles">All roles the employee is currently in</param>
        /// <returns></returns>
        public string CreateToken(Employee employee, IEnumerable<Role> roles)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = _jwtOptions.GetBytesFromKey;

            var claims = new List<Claim>()
            {
                 new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()), // unique id for token                 
                 new Claim(JwtRegisteredClaimNames.Sub, employee.Guid.ToString()), // user/employee id
                 new Claim(CustomJwtClaims.EmployeeUsername, employee.Username), // username of employee
                 new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()) // Issued at
            };

            claims.AddRange(roles.Select(r => new Claim(ClaimTypes.Role, r.Type.ToString())));

            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.Add(_jwtOptions.ValidFor),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
