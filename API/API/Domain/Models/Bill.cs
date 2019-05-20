using CLERP.API.Domain.Models.Abstract;
using CLERP.API.Domain.Models.Link;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Domain.Models
{
    /// <summary>
    /// Represents a bill in the Db
    /// A bill contains a reference to the order which has to be payed
    /// </summary>
    public class Bill : EntityBase
    {
        /// <summary>
        /// Datetime after which the this bill is valid
        /// </summary>
        public DateTime ValidFrom { get; set; }

        /// <summary>
        /// Number of days which result in the deadline for the payment of the bill when added to the valid from date
        /// </summary>
        public int AdditionalDeadlineDays { get; set; }

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
