using System.Collections.Generic;

namespace FluentAssertions
{
    public interface IThreadStorage
    {
        T Get<T>(string key);

        void Set(string key, object value);
    }
}