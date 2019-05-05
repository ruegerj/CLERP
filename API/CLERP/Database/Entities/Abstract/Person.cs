using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Database.Entities.Abstract
{
    /// <summary>
    /// Superclass for all people
    /// </summary>
    public abstract class Person : EntityBase
    {
        public string Lastname { get; set; }

        public string Firstname { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}
