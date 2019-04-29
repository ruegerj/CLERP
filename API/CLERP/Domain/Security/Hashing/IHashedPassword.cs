using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Domain.Security.Hashing
{
    public interface IHashedPassword
    {
        string HashBase64 { get; set; }
        string SaltBase64 { get; set; }
    }
}
