using System;
using System.Collections.Generic;

namespace FluentAssertions
{
    public interface IReflectionProvider
    {
        IEnumerable<Type> GetAllTypes { get; }
    }
}