namespace CLERP.API.Domain.Models.Abstract
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
