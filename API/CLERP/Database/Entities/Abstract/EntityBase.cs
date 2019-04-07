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
        /// Primary Key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Datetime when the entity was added to the table
        /// </summary>
        public DateTime Creation { get; set; }

        /// <summary>
        /// Datetime when the entity was the last time modified
        /// </summary>
        public DateTime LastModified { get; set; }
    }
}
