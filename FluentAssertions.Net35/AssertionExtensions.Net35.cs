namespace FluentAssertions
{
    public static partial class AssertionExtensions
    {
        static AssertionExtensions()
        {
            Providers.ThreadStorageProvider = new AttributeBasedThreadStorageProvider();
        }
    }
}