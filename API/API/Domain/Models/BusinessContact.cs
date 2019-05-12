using CLERP.API.Domain.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Domain.Models
{
    /// <summary>
    /// Represents a person from a <see cref="BusinessPartner"/> which acts as contact for that firm
    /// </summary>
    public class BusinessContact : Person
    {
        /// <summary>
        /// Foreign key to the business-partner this business-contact is attached to
        /// </summary>
        public Guid BusinessPartnerGuid { get; set; }

        /// <summary>
        /// The firm this person is working for
        /// </summary>
        public virtual BusinessPartner BusinessPartner { get; set; }

        /// <summary>
        /// All log entries for this business-contact
        /// </summary>
        public virtual ICollection<ContactLog> Logs { get; set; }
    }
}
