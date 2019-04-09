using CLERP.Database.Entities.Abstract;
using CLERP.Database.Entities.Link;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Database.Entities
{
    /// <summary>
    /// Represents a bill in the Db
    /// A bill contains a reference to the order which has to be payed
    /// </summary>
    public class Bill : EntityBase
    {
        /// <summary>
        /// Datetime which indicates to which date the bill has to be payed
        /// </summary>
        public DateTime PayableUntil { get; set; }

        /// <summary>
        /// Optional description
        /// </summary>
        public string Description { get; set; }

        public decimal TotalPrice { get; set; }

        public BillState State { get; set; }

        /// <summary>
        /// All delivered physical products from the order
        /// </summary>
        public virtual ICollection<Product> ProductsToPay { get; set; }

        /// <summary>
        /// Foreign key to the mapped order
        /// </summary>
        public Guid OrderGuid { get; set; }

        /// <summary>
        /// The mapped order to this bill
        /// </summary>
        public virtual Order Order { get; set; }
    }
}
