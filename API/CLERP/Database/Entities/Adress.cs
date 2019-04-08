using CLERP.Database.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Database.Entities
{
    /// <summary>
    /// Represents an adress of a company, warehouse etc.
    /// </summary>
    public class Adress : EntityBase
    {
        public int PostalCode { get; set; }

        /// <summary>
        /// The street name without the house-number
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// The housenumber , can be null if non existing
        /// </summary>
        public int? Housenumber { get; set; }

        /// <summary>
        /// The name of the city
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The mapped country
        /// </summary>
        public virtual Country Country { get; set; }

        /// <summary>
        /// All warehouses at this adress
        /// </summary>
        public virtual ICollection<Warehouse> Warehouses { get; set; }

        /// <summary>
        /// The business partner this adress is attached to
        /// </summary>
        public virtual BusinessPartner BusinessPartner { get; set; }
    }
}
