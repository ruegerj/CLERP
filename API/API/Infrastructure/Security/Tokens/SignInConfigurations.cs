using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;

namespace CLERP.API.Infrastructure.Security.Tokens
{
    /// <summary>
    /// Global Sign-In Configurations, generate on Startup an random crytpographical value wich acts as private key for token generation
    /// Instance is globally registered as singleton 
    /// </summary>
    public class SignInConfigurations
    {
        public SecurityKey Key { get; }
        public SigningCredentials SigningCredentials { get; }

        public SignInConfigurations()
        {
            using (var provider = new RSACryptoServiceProvider(2048))
            {
                Key = new RsaSecurityKey(provider.ExportParameters(true));
            }

            SigningCredentials = new SigningCredentials(Key, SecurityAlgorithms.RsaSha256Signature);
        }
    }
}
