using System.Security.Claims;

namespace CLERP.API.Infrastructure.Utilities
{
    public interface ICurrentUserAccessor
    {
        string GetId();

        string GetUsername();

        Claim GetIpAddressClaim();
    }
}
