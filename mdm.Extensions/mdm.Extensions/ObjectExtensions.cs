using System.Collections.Generic;
using System.Linq;

namespace mdm.Extensions
{
    /// <summary>
    /// Defines a set of extensions methods that can be used on any <see cref="object"/>.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Returns <see langword="true"/> if the given <paramref name="object"/> is equal to <see langword="null"/>
        /// (according to the <see langword="is"/> operator), otherwise <see langword="false"/>.
        /// </summary>
        public static bool IsNull(this object @object)
        {
            return @object is null;
        }

        /// <summary>
        /// Returns <see langword="true"/> if the given <paramref name="object"/> is not equal to <see langword="null"/>
        /// (according to the <see langword="is"/> operator), otherwise <see langword="false"/>.
        /// </summary>
        public static bool IsNotNull(this object @object)
        {
            return @object is null == false;
        }
    }

    /// <summary>
    /// Defines a set of extension methods that can be used on any <see cref="string"/>.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Returns <see langword="true"/> if the given <paramref name="string"/> is not null or empty
        /// (according to <see cref="string.IsNullOrEmpty(string)"/>), otherwise <see langword="false"/>.
        /// </summary>
        public static bool IsNotNullOrEmpty(this string @string)
        {
            return string.IsNullOrEmpty(@string) == false;
        }
    }

    /// <summary>
    /// Defines a set of extension of <see cref="IEnumerable"/>.
    /// </summary>
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Converts the given <paramref name="enumerable"/> into a 2D list where each row is <paramref name="rowLength"/> long.
        /// </summary>
        public static List<List<T>> To2DList<T>(this IEnumerable<T> enumerable, int rowLength)
        {
            List<List<T>> result = new List<List<T>>();

            int i = 0;
            foreach (T val in enumerable)
            {
                List<T> currentList;

                if (i % rowLength == 0)
                {
                    result.Add(currentList = new List<T>());
                }
                else
                {
                    currentList = result.Last();
                }

                currentList.Add(val);

                ++i;
            }

            return result;
        }
    }

}
