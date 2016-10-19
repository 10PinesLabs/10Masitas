using System.Collections;

namespace _10Masitas.Domain
{
    public static class ListExtensions
    {
        public static bool IsEmpty(this IList aList)
        {
            return aList.Count == 0;
        }
    }
}