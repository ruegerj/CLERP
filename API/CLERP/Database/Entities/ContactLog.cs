﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Database.Entities
{
    /// <summary>
    /// Represents a log for a business contact
    /// </summary>
    public class ContactLog : LogEntry
    {
        /// <summary>
        /// Link to the business-contact this log is attached
        /// </summary>
        public virtual BusinessContact Contact { get; set; }
    }
}
