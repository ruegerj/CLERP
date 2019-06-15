using CLERP.API.Domain.Models.Abstract;
using System;
using System.Collections.Generic;

namespace CLERP.API.Domain.Models
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
        /// FK to the shelf this compartment is in
        /// </summary>
        public Guid ShelfGuid { get; set; }

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
