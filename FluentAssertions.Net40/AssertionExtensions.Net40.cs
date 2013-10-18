using FluentAssertions.Execution;
using FluentAssertions.Formatting;

namespace FluentAssertions
{
    public static partial class AssertionExtensions
    {
        static AssertionExtensions()
        {
            Providers.ThreadStorageProvider = new AttributeBasedThreadStorageProvider();
            Providers.AssertionHelper = new AssertionHelper();
            Formatter.AddFormatter(new AttributeBasedFormatter());
            Formatter.AddFormatter(new AggregateExceptionValueFormatter());
        }
    }
}