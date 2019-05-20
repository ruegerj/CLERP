using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Utilities
{
    public interface ICurrentUserAccessor
    {
        string GetId();

        string GetUsername();
    }
}
