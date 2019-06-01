using Microsoft.AspNetCore.Authorization;

namespace CLERP.API.Infrastructure.Policies.Authorization.IpCheck
{
    /// <summary>
    /// Auth requirement which defines if the ip-rquired claim is required in the token, default is true
    /// </summary>
    public class IpCheckRequirement : IAuthorizationRequirement
    {
        public bool IpClaimRequired { get; set; } = true;
    }
}
