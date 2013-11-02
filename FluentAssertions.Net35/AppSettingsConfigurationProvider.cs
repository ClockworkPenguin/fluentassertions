using System.Configuration;

namespace FluentAssertions
{
    internal class AppSettingsConfigurationProvider : IConfigurationProvider
    {
        private const string AppSettingKey = "FluentAssertions.TestFramework";

        public string TestFramework
        {
            get { return ConfigurationManager.AppSettings[AppSettingKey]; }
        }
    }
}