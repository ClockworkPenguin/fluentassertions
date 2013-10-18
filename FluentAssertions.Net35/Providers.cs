namespace FluentAssertions
{
    public static class Providers
    {
        public static IConfigurationProvider ConfigurationProvider { get; set; }

        public static IThreadStorageProvider ThreadStorageProvider { get; set; }

        public static IReflectionProvider Reflection { get; set; }

        public static IAssertionHelper AssertionHelper { get; set; }
    }
}