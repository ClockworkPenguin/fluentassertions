using System.Collections.Generic;

namespace FluentAssertions
{
    public interface IThreadStorageProvider
    {
        T Get<T>(string key);

        void Set(string key, object value);
    }
}