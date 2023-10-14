using LOGGER.Entity;

namespace LOGGER
{
    /// <summary>
    /// Represents an interface for log sinks that handle log messages.
    /// </summary>
    public interface ISink
    {
        /// <summary>
        /// Logs a log message using the sink.
        /// </summary>
        /// <param name="message">The log message to be logged.</param>
        public void Log(LogMessage message);

        /// <summary>
        /// Determines whether the sink can handle log messages of the specified log level.
        /// </summary>
        /// <param name="level">The log level to check.</param>
        /// <returns>True if the sink can handle the specified log level; otherwise, false.</returns>
        public bool CanHandle(LogLevel level);

    }
}
