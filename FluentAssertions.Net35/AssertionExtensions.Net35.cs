using FluentAssertions.Execution;

namespace FluentAssertions
{
    public static partial class AssertionExtensions
    {
        static AssertionExtensions()
        {
            Providers.ThreadStorageProvider = new AttributeBasedThreadStorageProvider();
            Providers.AssertionHelper = new AssertionHelper();
            Providers.ConfigurationProvider = null;
        }
    }
}