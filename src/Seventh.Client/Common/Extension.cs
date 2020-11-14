using System;
using System.Collections.Generic;

namespace Seventh.Client.Common
{
    internal static class IEnumerableExtension
    {
        public static void ForEach<T>(this IEnumerable<T> self, Action<T> action)
        {
            foreach (var item in self) action(item);
        }
    }
}