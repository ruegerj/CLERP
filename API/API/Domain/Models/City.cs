using CLERP.API.Domain.Models.Abstract;
using System;
using System.Collections.Generic;

namespace CLERP.API.Domain.Models
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
        /// Foreign key to the country this city is attached
        /// </summary>
        public Guid CountryGuid { get; set; }

        /// <summary>
        /// The mapped country
        /// </summary>
        public virtual Country Country { get; set; }
    }
}
