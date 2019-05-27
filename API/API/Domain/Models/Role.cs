using CLERP.API.Domain.Models.Abstract;
using CLERP.API.Domain.Models.Link;
using System.Collections.Generic;

namespace CLERP.API.Domain.Models
{
    /// <summary>
    /// Represents a role that can be attached to a department or an individual employee
    /// </summary>
    public class Role : EntityBase
    {
        /// <summary>
        /// Unique name of the role
        /// Is used for Authorization
        /// </summary>
        public string Name { get; set; }

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
