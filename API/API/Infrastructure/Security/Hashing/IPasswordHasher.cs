using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Security.Hashing
{
    public interface IPasswordHasher
    {
        IHashedPassword HashPassword(string plainPassword);
        bool PasswordMatches(string plainPassword, string hashedPassword, string salt);
    }
}
