﻿using CLERP.API.Domain.Models.Abstract;
using System;
using System.Collections.Generic;

namespace CLERP.API.Domain.Models
{
    /// <summary>
    /// Represents a warehouse of the firm in the Db
    /// </summary>
    public class Warehouse : EntityBase
    {
        public string Name { get; set; }

        /// <summary>
        /// Foreign key for Address relation
        /// </summary>
        public Guid AddressGuid { get; set; }

        /// <summary>
        /// Link to the mapped warehouse-address
        /// </summary>
        public virtual Address Address { get; set; }

        /// <summary>
        /// All shelves inside this warehouse
        /// </summary>
        public virtual ICollection<Shelf> Shelves { get; set; }
    }
}
