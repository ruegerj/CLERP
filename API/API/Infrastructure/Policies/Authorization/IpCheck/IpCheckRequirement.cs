using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
