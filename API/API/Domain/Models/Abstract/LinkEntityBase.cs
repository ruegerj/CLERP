using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Domain.Models.Abstract
{
    /// <summary>
    /// Base class for an link-entity in the clerp Db
    /// </summary>
    public abstract class LinkEntityBase
    {
        /// <summary>
        /// Datetime when the entity was added to the table
        /// </summary>
        public DateTime Creation { get; set; }

        /// <summary>
        /// Username of the employee which created this entity
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Datetime when the entity was the last time modified
        /// </summary>
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Username of the employee which last modified this entity
        /// </summary>
        public string LastModifiedBy { get; set; }
    }
}
