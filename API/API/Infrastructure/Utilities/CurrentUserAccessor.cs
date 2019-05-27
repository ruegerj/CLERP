using CLERP.API.Infrastructure.Security.Tokens;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;

namespace CLERP.API.Infrastructure.Utilities
{
    /// <summary>
    /// Content accesor which fetches data about the current user (current request) from the current HttpContext
    /// </summary>
    public class CurrentUserAccessor : ICurrentUserAccessor
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUserAccessor(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetId()
        {
            return GetUserClaims()?.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Sub)?.Value;
        }

        public string GetUsername()
        {
            return GetUserClaims()?.FirstOrDefault(c => c.Type == CustomJwtClaims.EmployeeUsername)?.Value;
        }

        /// <summary>
        /// Returns the custom claim for the ip adress
        /// </summary>
        /// <returns></returns>
        public Claim GetIpAddressClaim()
        {
            return GetUserClaims()?.FirstOrDefault(c => c.Type == CustomJwtClaims.IpAddress);
        }

        private IEnumerable<Claim> GetUserClaims()
        {
            return _httpContextAccessor?.HttpContext.User?.Claims;
        }
    }
}
