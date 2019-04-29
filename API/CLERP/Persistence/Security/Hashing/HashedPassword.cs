using CLERP.Domain.Security.Hashing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Persistence.Security.Hashing
{
    /// <summary>
    /// Object which a hasher implentation of IPasswordHasher returns
    /// </summary>
    public class HashedPassword : IHashedPassword
    {
        public HashedPassword(string hashBase64, string saltBase64)
        {
            HashBase64 = hashBase64;
            SaltBase64 = saltBase64;
        }

        public string HashBase64 { get; set; }

        public string SaltBase64 { get; set; }
    }
}
