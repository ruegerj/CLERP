namespace CLERP.API.Infrastructure.Security.Tokens
{
    /// <summary>
    /// Constins custom claims for JWt created within this app
    /// </summary>
    public class CustomJwtClaims
    {
        /// <summary>
        /// Claim key for a username of an employee
        /// </summary>
        public const string EmployeeUsername = "eun";

        /// <summary>
        /// Claim key for the ip-adress where the login request came from
        /// </summary>
        public const string IpAddress = "ip";
    }
}
