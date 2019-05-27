namespace CLERP.API
{
    /// <summary>
    /// Represents the custom settings from the appsettings.json file
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// Connection-string to local dev DB
        /// </summary>
        public string ConnectionstringLocal { get; set; }

        /// <summary>
        /// May age of HSTS in days
        /// </summary>
        public int HSTSMaxAge { get; set; }
    }
}
