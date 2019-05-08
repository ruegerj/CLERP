using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Security.Jwt
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
    }
}
