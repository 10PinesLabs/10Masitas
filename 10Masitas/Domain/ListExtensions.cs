using System.Collections.Generic;

namespace _10Masitas.Domain
{
    public static class ListExtensions
    {
        public static bool IsEmpty<T>(this IList<T> aList)
        {
            return aList.Count == 0;
        }
    }
}