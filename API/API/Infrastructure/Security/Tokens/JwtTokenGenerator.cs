using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CLERP.API.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace CLERP.API.Infrastructure.Security.Tokens
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly JwtOptions _jwtOptions;
        private readonly SignInConfigurations _signInConfigurations;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public JwtTokenGenerator(IOptions<JwtOptions> jwtOptions, 
            SignInConfigurations signInConfigurations,
            IHttpContextAccessor httpContextAccessor)
        {
            _jwtOptions = jwtOptions.Value;
            _signInConfigurations = signInConfigurations;
            _httpContextAccessor = httpContextAccessor;
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
            var key = _signInConfigurations.Key;

            var claims = new List<Claim>()
            {
                 new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()), // unique id for token                 
                 new Claim(JwtRegisteredClaimNames.Sub, employee.Guid.ToString()), // user/employee id
                 new Claim(CustomJwtClaims.EmployeeUsername, employee.Username), // username of employee
                 new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()), // Issued at
                 new Claim(CustomJwtClaims.IpAddress, _httpContextAccessor.HttpContext.Connection.RemoteIpAddress?.ToString()) // current request ip
            };

            claims.AddRange(roles.Select(r => new Claim(ClaimTypes.Role, r.Name)));

            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.Add(_jwtOptions.ValidFor),
                SigningCredentials = _signInConfigurations.SigningCredentials
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
