﻿using CLERP.Business.Models.Abstract;
using CLERP.Business.Models.Link;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Business.Models
{
    /// <summary>
    /// Represents a department in the Db
    /// Every employee can belong to one department wich has specific roles attached
    /// </summary>
    public class Department : EntityBase
    {
        public string Title { get; set; }

        /// <summary>
        /// Optional description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// All roles wich are claimed by this department
        /// </summary>
        public virtual ICollection<RoleDepartment> Roles { get; set; }

        /// <summary>
        /// All employee which are attached to this department
        /// </summary>
        public virtual ICollection<Employee> Employees { get; set; }
    }
}