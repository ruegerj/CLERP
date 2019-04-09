using CLERP.Database.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Database.Entities
{
    /// <summary>
    /// Represents an order in the Db
    /// Can be an incoming order (from one of the business-partners of this firm)
    /// Or can be an outgoing order (from our firm to one of the business-partners)
    /// </summary>
    public class Order : EntityBase
    {
        /// <summary>
        /// From this date the order is valid
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Optional description
        /// </summary>
        public string Description { get; set; }

        public decimal TotalPrice { get; set; }

        public OrderState State { get; set; }

        /// <summary>
        /// Foreign key for the sending business-partner
        /// </summary>
        public Guid SendingPartnerGuid { get; set; }

        /// <summary>
        /// Business-partner which sends this order
        /// </summary>
        public virtual BusinessPartner SendingPartner { get; set; }

        /// <summary>
        /// Foreign key for the receiving business-partner
        /// </summary>
        public Guid ReceivingPartnerGuid { get; set; }

        /// <summary>
        /// Business-partner which receives this order
        /// </summary>
        public virtual BusinessPartner ReceivingPartner { get; set; }

        /// <summary>
        /// Foreign key to shipping address
        /// </summary>
        public Guid ShippingAddressGuid { get; set; }

        /// <summary>
        /// The address where the products should be shipped to
        /// </summary>
        public virtual Address ShippingAddress { get; set; }

        /// <summary>
        /// Foreign key to the billing address
        /// </summary>
        public Guid BillingAddressGuid { get; set; }

        /// <summary>
        /// The address the bill should go to
        /// </summary>
        public virtual Address BillingAddress { get; set; }
    }
}
