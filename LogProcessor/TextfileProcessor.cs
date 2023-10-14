using LOGGER.Entity;

namespace LOGGER.LogProcessor
{
    /// <summary>
    /// Represents a log sink that logs messages to a text file.
    /// </summary>
    public class TextfileProcessor : ISink
    {
        private string _filePath;

        /// <summary>
        /// Initializes a new instance of the <see cref="TextfileProcessor"/> class with the specified file path.
        /// </summary>
        /// <param name="filePath">The file path where log messages will be written.</param>
        public TextfileProcessor(string filePath)
        {
            _filePath = filePath;
        }


        /// <summary>
        /// Determines whether the sink can handle log messages of the specified log level.
        /// The TextfileProcessor handles INFO and ERROR messages.
        /// </summary>
        /// <param name="level">The log level to check.</param>
        /// <returns>True if the sink can handle the specified log level; otherwise, false.</returns>
        public virtual bool CanHandle(LogLevel level)
        {
            // TextFileProcessor handles INFO and ERROR messages
            return level == LogLevel.INFO || level == LogLevel.ERROR;

        }

        /// <summary>
        /// Logs a log message to the text file.
        /// </summary>
        /// <param name="message">The log message to be logged.</param>
        public virtual void Log(LogMessage message)
        {
            File.AppendAllText(_filePath, $"{message.Level}: {message.Content}\n");
            //Write Logic for text file logging
        }
    }
}
