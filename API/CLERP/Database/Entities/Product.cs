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

        public string SerialNumber { get; set; }

        public ProductState State { get; set; }

        /// <summary>
        /// European Article Number 
        /// </summary>
        public string EAN { get; set; }        

        /// <summary>
        /// The physical location of the product
        /// </summary>
        public virtual Compartment Compartment { get; set; }        
    }
}
