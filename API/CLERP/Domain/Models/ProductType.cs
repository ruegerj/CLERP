using CLERP.Domain.Models.Abstract;
using CLERP.Domain.Models.Link;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Domain.Models
{
    /// <summary>
    /// Represents a type of a product
    /// </summary>
    public class ProductType : EntityBase
    {
        public string Name { get; set; }

        /// <summary>
        /// Optional description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// European Article Number 
        /// </summary>
        public string EAN { get; set; }

        /// <summary>
        /// The price of the physical product wiht this type
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// All parent product-types which have this product type as child
        /// </summary>
        public virtual ICollection<ProductTypeProductType> Parents { get; set; }

        /// <summary>
        /// All child product-types which have this product type as parent
        /// </summary>
        public virtual ICollection<ProductTypeProductType> Children { get; set; }

        /// <summary>
        /// All products which have this type
        /// </summary>
        public virtual ICollection<Product> Products { get; set; }

        /// <summary>
        /// All Orders which contained this product
        /// </summary>
        public virtual ICollection<ProductTypeOrder> Orders { get; set; }
    }
}
