using LOGGER.Entity;

namespace LOGGER.LogProcessor
{
    /// <summary>
    /// Represents a log sink that logs messages to the console.
    /// </summary>
    public class ConsoleProcessor : ISink
    {
        /// <summary>
        /// Determines whether the sink can handle log messages of the specified log level.
        /// The ConsoleProcessor can handle all log levels.
        /// </summary>
        /// <param name="level">The log level to check.</param>
        /// <returns>True if the sink can handle the specified log level; otherwise, false.</returns>
        public virtual bool CanHandle(LogLevel level)
        {
            // SqlDbProcessor will handle All kind of levels
            return level == LogLevel.ERROR || level == LogLevel.INFO || 
                   level == LogLevel.WARN || level == LogLevel.DEBUG ||
                   level == LogLevel.FATAL;

        }

        /// <summary>
        /// Logs a log message to the console.
        /// </summary>
        /// <param name="message">The log message to be logged.</param>
        public virtual void Log(LogMessage message)
        {
            // Write Logic before displaying console if any.
            Console.WriteLine($"{message.Level}: {message.Content}");
            
        }
    }
}
