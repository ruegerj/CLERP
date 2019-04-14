using CLERP.Domain.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Domain.Models
{
    /// <summary>
    /// Represents a compartment inside a shelf
    /// Is the physical place where a product is stored
    /// </summary>
    public class Compartment : EntityBase
    {
        /// <summary>
        /// The row number inside the compartment grid
        /// </summary>
        public int Row { get; set; }

        /// <summary>
        /// The column number inside the compartment grid
        /// </summary>
        public int Column { get; set; }

        /// <summary>
        /// The shelf this compartmnet is inside
        /// </summary>
        public virtual Shelf Shelf { get; set; }

        /// <summary>
        /// All products which are stored inside this compartment
        /// </summary>
        public virtual ICollection<Product> Products { get; set; }
    }
}
