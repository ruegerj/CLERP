using CLERP.API.Domain.Models.Abstract;
using CLERP.API.Domain.Models.Link;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Domain.Models
{
    /// <summary>
    /// Represents an employee of the firm in the Db
    /// </summary>
    public class Employee : Person
    {
        public string Username { get; set; }

        /// <summary>
        /// A 512 bit hash (Sha-512) as a Base64String which represents the hashed password of an employee
        /// </summary>
        public string Password { get; set; }

        public DateTime Birthday { get; set; }

        /// <summary>
        /// Foreign key to the department this employee works for
        /// </summary>
        public Guid? DepartmentGuid { get; set; } = null;

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
