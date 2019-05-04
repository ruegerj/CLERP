using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Utilities
{
    /// <summary>
    /// Content accesor which fetches data about the current user (current request) from the current HttpContext
    /// </summary>
    public class CurrentUserAccessor : ICurrentUserAccessor
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        private IEnumerable<Claim> _userClaims;

        public CurrentUserAccessor(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;

            // Prevent NullReferenceException while Migration-Buidling and DB-Updates
            if (_httpContextAccessor != null && _httpContextAccessor.HttpContext != null)
            {
                GetUserClaims();
            }
        }

        public string GetCurrentUsername()
        {
            return _userClaims?.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
        }

        private void GetUserClaims()
        {
            _userClaims = _httpContextAccessor?.HttpContext.User?.Claims;
        }
    }
}
