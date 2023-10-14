using LOGGER.Entity;
using LOGGER.LogProcessor;

namespace LOGGER
{
    /// <summary>
    /// Represents a logger for the application that manages various log sinks.
    /// </summary>
    public class ApplicationLogger
    {
        private List<ISink> sinks = new List<ISink>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationLogger"/> class based on the provided configuration.
        /// </summary>
        /// <param name="configuration">The configuration settings for the logger.</param>
        public  ApplicationLogger(LogConfiguration configuration)
        {
            // Initialize and configure sinks based on the provided configuration.
            foreach (var singleConfiguration in configuration.SinkConfigurations)
            {
                var sinkName = singleConfiguration.Key;
                var sinkConfiguration = singleConfiguration.Value;
                ISink sink = CreateSinkFromConfiguration(sinkName, sinkConfiguration);
                if (sink != null)
                {
                    sinks.Add(sink);
                }
            }
        }

        /// <summary>
        /// Logs a log message to all configured sinks based on the message's log level.
        /// </summary>
        /// <param name="message">The log message to be logged.</param>
        public virtual void LogMessage(LogMessage message)
        {
            // Determine which sinks can log the message based on message level.
            foreach (var sink in sinks)
            {
                if (sink.CanHandle(message.Level))
                {
                    sink.Log(message);
                }
            }
        }

        private ISink CreateSinkFromConfiguration(string sinkName, string configuration)
        {
            // Implement logic to create the appropriate sink based on configuration.
            // You may parse the configuration string and create the sink accordingly.
            // For simplicity, we'll assume two predefined sink types: TextFileSink and DatabaseSink.
            switch (sinkName)
            {
                case "TextFileSink":
                    return new TextfileProcessor(configuration);
                case "DatabaseSink":
                    return new SqlDbProcessor(configuration);
                case "ConsoleSink":
                    return new ConsoleProcessor();
                default:
                    return null;
            }
        }

    }
}
