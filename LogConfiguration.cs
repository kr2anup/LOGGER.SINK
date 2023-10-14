namespace LOGGER
{
    /// <summary>
    /// Represents the configuration settings for the logger, including sink configurations.
    /// </summary>
    public class LogConfiguration
    {
        /// <summary>
        /// Gets a dictionary of sink configurations, where the key is the sink name and the value is the configuration string.
        /// </summary>
        public Dictionary<string, string> SinkConfigurations { get; } = new Dictionary<string, string>();


        /// <summary>
        /// Adds a new sink configuration to the dictionary.
        /// </summary>
        /// <param name="sinkName">The name of the sink to configure.</param>
        /// <param name="configuration">The configuration string for the sink.</param>
        public void AddSinkConfiguration(string sinkName, string configuration)
        {
            SinkConfigurations[sinkName] = configuration;
        }

    }
}
