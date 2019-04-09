using CLERP.Database.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Database.Entities
{
    /// <summary>
    /// Represents a City in the Db
    /// </summary>
    public class City : EntityBase
    {
        public string Name { get; set; }

        public int PostalCode { get; set; }

        /// <summary>
        /// All addresses within this city
        /// </summary>
        public virtual ICollection<Address> Addresses { get; set; }

        /// <summary>
        /// The mapped country
        /// </summary>
        public virtual Country Country { get; set; }
    }
}
