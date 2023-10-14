namespace LOGGER.Entity
{
    /// <summary>
    /// Represents a log message with content, log level, and namespace information.
    /// </summary>
    public class LogMessage
    {
        /// <summary>
        /// Gets or sets the content of the log message.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the log level of the message.
        /// </summary>
        public LogLevel Level { get; set; }
        
        /// <summary>
        /// Gets or sets the namespace associated with the message to identify the part of the application that sent the message.
        /// </summary>
        public string Namespace { get; set; }

    }
}
