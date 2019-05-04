using CLERP.API.Domain.Models.Abstract;
using CLERP.API.Domain.Models.Link;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Domain.Models
{
    /// <summary>
    /// Represents a role that can be attached to a department or an individual employee
    /// </summary>
    public class Role : EntityBase
    {
        /// <summary>
        /// Defines the explicit type / function
        /// Is used for authorization
        /// </summary>
        public RoleType Type { get; set; }

        /// <summary>
        /// Optional description of the role
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// All people wich claimed this role
        /// </summary>
        public virtual ICollection<RoleEmployee> Employees { get; set; }

        /// <summary>
        /// All departments which claimed this role
        /// </summary>
        public virtual ICollection<RoleDepartment> Departments { get; set; }
    }
}
