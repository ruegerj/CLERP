using CLERP.Business.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Business.Models
{
    /// <summary>
    /// Represents a log for a business-partner
    /// </summary>
    public class PartnerLog : LogEntry
    {
        /// <summary>
        /// Foreign key to the business-partner this log entry is attached
        /// </summary>
        public Guid PartnerGuid { get; set; }

        /// <summary>
        /// Link to the business-partner this log is attached
        /// </summary>
        public virtual BusinessPartner Partner { get; set; }
    }
}
