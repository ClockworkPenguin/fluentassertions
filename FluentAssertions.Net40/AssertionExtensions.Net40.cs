using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
