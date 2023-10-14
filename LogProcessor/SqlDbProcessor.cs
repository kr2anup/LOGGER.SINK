using LOGGER.Entity;

namespace LOGGER.LogProcessor
{
    /// <summary>
    /// Represents a log sink that logs messages to a SQL database.
    /// </summary>
    public class SqlDbProcessor : ISink
    {
        private string _connectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlDbProcessor"/> class with the specified connection string.
        /// </summary>
        /// <param name="connectionString">The connection string to the SQL database.</param>
        public SqlDbProcessor(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Determines whether the sink can handle log messages of the specified log level.
        /// The SqlDbProcessor handles ERROR and FATAL messages only.
        /// </summary>
        /// <param name="level">The log level to check.</param>
        /// <returns>True if the sink can handle the specified log level; otherwise, false.</returns>
        public virtual bool CanHandle(LogLevel level)
        {
            // SqlDbProcessor will handle ERROR & FATAL messages only
            return level == LogLevel.ERROR || level == LogLevel.FATAL;

        }

        /// <summary>
        /// Logs a log message to the SQL database.
        /// </summary>
        /// <param name="message">The log message to be logged.</param>
        public virtual void Log(LogMessage message)
        {
            // Write Logic for Sql Db logging.
            // you can create a DB processor and can use here. 
        }
    }
}
