using CLERP.API.Domain.Models.Abstract;
using System.Collections.Generic;

namespace CLERP.API.Domain.Models
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
