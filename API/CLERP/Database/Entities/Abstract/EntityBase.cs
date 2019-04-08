using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Database.Entities.Abstract
{
    /// <summary>
    /// Base class for an entity in the clerp Db
    /// </summary>
    public abstract class EntityBase
    {
        /// <summary>
        /// GUID as primary Key
        /// </summary>
        public Guid Guid { get; set; }

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
