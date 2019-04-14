using CLERP.Domain.Models.Abstract;
using CLERP.Domain.Models.Link;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Domain.Models
{
    /// <summary>
    /// Represents an order in the Db
    /// Is an order for specific products (types) sendt to a business partner or to this firm
    /// </summary>
    public class Order : EntityBase
    {
        /// <summary>
        /// Date when the order was sendt
        /// </summary>
        public DateTime SendDate { get; set; }

        /// <summary>
        /// Optional description
        /// </summary>
        public string Description { get; set; }

        public OrderState State { get; set; }

        public decimal EstimatedPrice { get; set; }

        /// <summary>
        /// All types and count for each type for all ordered products
        /// </summary>
        public virtual ICollection<ProductTypeOrder> ProductTypes { get; set; }

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

        /// <summary>
        /// Foreign key to the attached bill
        /// </summary>
        public Guid BillGuid { get; set; }

        /// <summary>
        /// The bill for this order
        /// </summary>
        public virtual Bill Bill { get; set; }
    }
}
