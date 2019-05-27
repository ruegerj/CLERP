using CLERP.API.Domain.Models.Abstract;
using System;

namespace CLERP.API.Domain.Models
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
