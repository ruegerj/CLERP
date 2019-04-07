using CLERP.Database.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Database.Entities
{
    /// <summary>
    /// Represents a person from a <see cref="BusinessPartner"/> which acts as contact for that firm
    /// </summary>
    public class BusinessContact : Person
    {
        /// <summary>
        /// The firm this person is working for
        /// </summary>
        public virtual BusinessPartner BusinessPartner { get; set; }
    }
}
