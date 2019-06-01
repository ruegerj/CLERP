using CLERP.API.Domain.Models.Abstract;
using System.Collections.Generic;

namespace CLERP.API.Domain.Models
{
    /// <summary>
    /// Represents a business contact e.g. another firm or business partner
    /// </summary>
    public class BusinessPartner : EntityBase
    {
        public string Name { get; set; }

        /// <summary>
        /// All orders this business-partner has received
        /// </summary>
        public virtual ICollection<Order> ReceivedOrders { get; set; }

        /// <summary>
        /// All orders this business-partner has sendt
        /// </summary>
        public virtual ICollection<Order> SendtOrders { get; set; }

        /// <summary>
        /// All business contacts / persons registered for this firm
        /// </summary>
        public virtual ICollection<BusinessContact> Contacts { get; set; }

        /// <summary>
        /// All logs for this business partner
        /// </summary>
        public virtual ICollection<PartnerLog> Logs { get; set; }

        /// <summary>
        /// All adresses of this business partner (e.g. multple office- or warehouse-, factory- locations)
        /// </summary>
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
