using CLERP.Database.Entities.Abstract;
using CLERP.Database.Entities.Link;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Database.Entities
{
    /// <summary>
    /// Represents an employee of the firm in the Db
    /// </summary>
    public class Employee : Person
    {               
        public string Username { get; set; }

        /// <summary>
        /// A 512 bit hash (Sha-512) wich represents the hashed password of an employee
        /// </summary>
        public string Password { get; set; }

        public DateTime Birthday { get; set; }

        /// <summary>
        /// The department this employee is attached to
        /// </summary>
        public virtual Department Department { get; set; }

        /// <summary>
        /// All roles wich are claimed by this person
        /// </summary>
        public virtual ICollection<RoleEmployee> Roles { get; set; }
    }
}
