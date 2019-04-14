using CLERP.Domain.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Domain.Models
{
    /// <summary>
    /// Represents a country in the Db
    /// </summary>
    public class Country : EntityBase
    {
        public string Name { get; set; }

        /// <summary>
        /// The abbrevation of the country e.g. Switzerland => CHE
        /// Three digit country codes
        /// </summary>
        public string Abbreviation { get; set; }

        /// <summary>
        /// All cities which are in this country
        /// </summary>
        public virtual ICollection<City> Cities { get; set; }
    }
}
