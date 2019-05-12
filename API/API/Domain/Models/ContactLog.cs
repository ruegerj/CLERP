using CLERP.API.Domain.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Domain.Models
{
    /// <summary>
    /// Represents a log for a business contact
    /// </summary>
    public class ContactLog : LogEntry
    {
        /// <summary>
        /// Foreign key to the business-contact this log-entry is attached
        /// </summary>
        public Guid ContactGuid { get; set; }

        /// <summary>
        /// Link to the business-contact this log is attached
        /// </summary>
        public virtual BusinessContact Contact { get; set; }
    }
}
