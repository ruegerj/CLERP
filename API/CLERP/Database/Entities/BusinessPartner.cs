using CLERP.Database.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Database.Entities
{
    /// <summary>
    /// Represents a business contact e.g. another firm or business partner
    /// </summary>
    public class BusinessPartner : EntityBase
    {
        public string Name { get; set; }

        // Relation to order for order-history

        /// <summary>
        /// All business contacts / persons registered for this firm
        /// </summary>
        public virtual ICollection<BusinessContact> Contacts { get; set; }

        /// <summary>
        /// All adresses of this business partner (e.g. multple office locations)
        /// </summary>
        public virtual ICollection<Adress> Adresses { get; set; }
    }
}
