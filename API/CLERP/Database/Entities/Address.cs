using CLERP.Database.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Database.Entities
{
    /// <summary>
    /// Base class for an adress
    /// </summary>
    public class Address : EntityBase
    {
        /// <summary>
        /// The street name without the house-number
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// The housenumber , can be null if non existing
        /// </summary>
        public int? Housenumber { get; set; }

        /// <summary>
        /// Foreign key to the city this address is attached
        /// </summary>
        public Guid CityGuid { get; set; }

        /// <summary>
        /// The mapped City to this address
        /// </summary>
        public virtual City City { get; set; }

        /// <summary>
        /// The warehouse which have this address
        /// </summary>
        public virtual Warehouse Warehouse { get; set; }

        /// <summary>
        /// Foreign key to the business-partner this address is attached
        /// </summary>
        public Guid BusinessPartnerGuid { get; set; }

        /// <summary>
        /// The business-partner this address is attached to
        /// </summary>
        public virtual BusinessPartner BusinessPartner { get; set; }

        /// <summary>
        /// All orders where this is the shipping address
        /// </summary>
        public virtual ICollection<Order> ShippingOrders { get; set; }

        /// <summary>
        /// All orders where this is the billing address
        /// </summary>
        public virtual ICollection<Order> BillingOrders { get; set; }
    }
}
