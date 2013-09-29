using FluentAssertions.Execution;

namespace FluentAssertions
{
    public static class Providers
    {
        public static IConfiguration Configuration { get; set; }

        public static IThreadStorage ThreadStorage { get; set; }
    }

    public interface IConfiguration
    {
        string TestFramework { get; }
    }
}
