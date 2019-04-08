using CLERP.Database.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Database.Entities
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
        /// All adresses which have this country attached
        /// </summary>
        public virtual ICollection<Adress> Adresses { get; set; }
    }
}
