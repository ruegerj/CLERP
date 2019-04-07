using CLERP.Database.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Database.Entities
{
    /// <summary>
    /// Represents a physical product in the Db
    /// Each product can have a parent product
    /// </summary>
    public class Product : EntityBase
    {
        public string Name { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Price of the product in CHF
        /// </summary>
        public decimal Price { get; set; }

        public string SerialNumber { get; set; }

        /// <summary>
        /// European Article Number 
        /// </summary>
        public string EAN { get; set; }

        /// <summary>
        /// Foreig key to the parent product
        /// </summary>
        public int ParentId { get; set; }

        /// <summary>
        /// The physical location of the product
        /// </summary>
        public virtual Compartment Compartment { get; set; }

        /// <summary>
        /// The parent product => the product this is attached to
        /// </summary>
        public virtual Product Parent { get; set; }

        /// <summary>
        /// All child products which are attached to this product
        /// </summary>
        public virtual ICollection<Product> Children { get; set; }
    }
}
