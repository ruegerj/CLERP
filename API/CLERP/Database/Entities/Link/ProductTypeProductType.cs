using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Database.Entities.Link
{
    /// <summary>
    /// Link table for the many to many relation
    /// between the Parent Product-Type and the Child Product-Type
    /// </summary>
    public class ProductTypeProductType
    {
        /// <summary>
        /// Foreign key to the parent product-type
        /// </summary>
        public Guid ParentGuid { get; set; }

        /// <summary>
        /// Foreign key to the child product-type
        /// </summary>
        public Guid ChildGuid { get; set; }

        /// <summary>
        /// Link to the parent product-type
        /// </summary>
        public virtual ProductType Parent { get; set; }

        /// <summary>
        /// Link to the child product-type
        /// </summary>
        public virtual ProductType Child { get; set; }
    }
}
