using FluentAssertions.Execution;
using FluentAssertions.Formatting;

namespace FluentAssertions
{
    public static partial class AssertionExtensions
    {
        static AssertionExtensions()
        {
            Formatter.AddFormatter(new AttributeBasedFormatter());
            Providers.ThreadStorageProvider = new AttributeBasedThreadStorageProvider();
            Providers.AssertionHelper = new AssertionHelper();
            Providers.ConfigurationProvider = new AppSettingsConfigurationProvider();
        }
    }
}