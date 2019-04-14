using CLERP.Domain.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Domain.Models.Abstract
{
    /// <summary>
    /// Represents base class for a log / note
    /// </summary>
    public abstract class LogEntry : EntityBase
    {
        /// <summary>
        /// The logged text/message
        /// </summary>
        public string LogMessage { get; set; }
    }
}
