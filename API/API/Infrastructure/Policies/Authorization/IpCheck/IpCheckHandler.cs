using CLERP.API.Infrastructure.Security.Tokens;
using CLERP.API.Infrastructure.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Policies.Authorization.IpCheck
{
    public class IpCheckHandler : AuthorizationHandler<IpCheckRequirement>
    {
        private readonly ICurrentUserAccessor _currentUserAccessor;
        private readonly IHttpContextAccessor _httpContextAccessor;

        private HttpContext HttpContext => _httpContextAccessor.HttpContext;

        public IpCheckHandler(ICurrentUserAccessor currentUserAccessor, IHttpContextAccessor httpContextAccessor)
        {
            _currentUserAccessor = currentUserAccessor;
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentException(nameof(httpContextAccessor));
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IpCheckRequirement requirement)
        {
            Claim ipClaim = _currentUserAccessor.GetIpAddressClaim();

            // token doesn't contain the ip-address claim or ip-address claim isn't required => skip ip check
            if (ipClaim == null || !requirement.IpClaimRequired)
            {
                return Task.CompletedTask;
            }

            if (ipClaim.Value ==  HttpContext.Connection.RemoteIpAddress?.ToString())
            {
                // ip-address from token and current matches => access granted
                context.Succeed(requirement);
            }
            else
            {
                // current ip from request doesn't match the ip which the employee had when he generated the access token
                // this could be a potentially stolen token => reject request and block access, will result in a 403 - Forbidden
                context.Fail();
            }

            return Task.CompletedTask;
        }
    }
}
