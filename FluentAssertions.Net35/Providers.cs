using System;
using System.Collections.Generic;

namespace FluentAssertions
{
    public static class Providers
    {
        public static IConfigurationProvider ConfigurationProvider { get; set; }

        public static IThreadStorageProvider ThreadStorageProvider { get; set; }

        public static IReflectionProvider Reflection { get; set; }
    }

    public interface IReflectionProvider
    {
        IEnumerable<Type> GetAllTypes { get; }
    }

    public interface IConfigurationProvider
    {
        string TestFramework { get; }
    }
}