using CLERP.API.Domain.Models.Abstract;
using System;

namespace CLERP.API.Domain.Models.Link
{
    /// <summary>
    /// Link table for many to many relation of <see cref="Role"/> to <see cref="Employee"/>
    /// </summary>
    public class RoleEmployee : LinkEntityBase
    {
        /// <summary>
        /// Foreig key for Role
        /// </summary>
        public Guid RoleGuid { get; set; }

        /// <summary>
        /// Foreig key for Employee
        /// </summary>
        public Guid EmployeeGuid { get; set; }

        /// <summary>
        /// Link to the mapped role
        /// </summary>
        public virtual Role Role { get; set; }

        /// <summary>
        /// Link to the mapped employee
        /// </summary>
        public virtual Employee Employee { get; set; }
    }
}
