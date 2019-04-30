using CLERP.Business.Models.Abstract;
using CLERP.Business.Models.Link;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Business.Models
{
    /// <summary>
    /// Represents a physical product in the Db
    /// Each product can have a parent product
    /// </summary>
    public class Product : EntityBase
    {
        public string Name { get; set; }

        /// <summary>
        /// Optional description
        /// </summary>
        public string Description { get; set; }

        public string SerialNumber { get; set; }

        public ProductState State { get; set; }

        /// <summary>
        /// Foreign key to parent product
        /// </summary>
        public Guid ParentGuid { get; set; }

        /// <summary>
        /// The parent product of this product
        /// </summary>
        public virtual Product Parent { get; set; }

        /// <summary>
        /// All child prodcuts of this product
        /// </summary>
        public virtual ICollection<Product> Children { get; set; }

        /// <summary>
        /// Foreign key to the product-type of this product
        /// </summary>
        public virtual Guid TypeGuid { get; set; }

        /// <summary>
        /// The type this product is attached to
        /// </summary>
        public virtual ProductType Type { get; set; }

        /// <summary>
        /// Foreign key to the compartment this product is stored
        /// </summary>
        public Guid CompartmentGuid { get; set; }

        /// <summary>
        /// The physical location of the product
        /// </summary>
        public virtual Compartment Compartment { get; set; }

        /// <summary>
        /// Foreign key to the bill which includes this product
        /// </summary>
        public Guid BillGuid { get; set; }

        /// <summary>
        /// The bill which includes this product
        /// </summary>
        public virtual Bill Bill { get; set; }
    }
}
