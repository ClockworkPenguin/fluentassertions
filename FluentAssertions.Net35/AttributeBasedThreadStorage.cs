using System;
using System.Collections.Generic;

namespace FluentAssertions
{
    internal class AttributeBasedThreadStorageProvider : IThreadStorageProvider
    {
        [ThreadStatic]
        private static Dictionary<string, object> dictionary; 

        public T Get<T>(string key)
        {
            return (T)Dictionary[key];
        }

        public void Set(string key, object value)
        {
            Dictionary[key] = value;
        }

        public static Dictionary<string, object> Dictionary
        {
            get
            {
                if (dictionary == null)
                {
                    dictionary = new Dictionary<string, object>();
                }

                return dictionary;
            }
        }
    }
}