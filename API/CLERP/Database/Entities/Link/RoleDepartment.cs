using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Database.Entities.Link
{
    /// <summary>
    /// Link table for many to many relation of <see cref="Role"/> to <see cref="Department"/>
    /// </summary>
    public class RoleDepartment
    {
        /// <summary>
        /// Foreign key for Role
        /// </summary>
        public Guid RoleGuid { get; set; }

        /// <summary>
        /// Foreign key for Department
        /// </summary>
        public Guid DepartmentGuid { get; set; }

        /// <summary>
        /// Link to mapped Role
        /// </summary>
        public virtual Role Role { get; set; }

        /// <summary>
        /// Link to mapped Department
        /// </summary>
        public virtual Department Department { get; set; }
    }
}
