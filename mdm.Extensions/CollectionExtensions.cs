using System;
using System.Collections.Generic;
using System.Linq;

namespace mdm.Extensions
{
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

    /// <summary>
    /// Defines a set of extensions on <see cref="IDictionary{TKey, TValue}"/>.
    /// </summary>
    public static class IDictionaryExtensions
    {
        /// <summary>
        /// Given a <paramref name="dictionary"/> with an <see cref="ICollection{TValue}"/> value type, checks if the given
        /// <paramref name="key"/>'s value exists. If not, a new <see cref="List{TValue}"/> is created for the given <paramref name="key"/> with one element, the given <paramref name="value"/>.
        /// If it already exists, the given <paramref name="value"/> is added to <paramref name="key"/>'s value collection.
        /// </summary>
        /// <exception cref="ArgumentNullException"/>
        public static void AddToCollection<TKey, TCollection, TValue>(this IDictionary<TKey, TCollection> dictionary, TKey key, TValue value) where TCollection : ICollection<TValue>, new()
        {
            if (dictionary is null)
            {
                throw new ArgumentNullException(nameof(dictionary));
            }

            if (dictionary.TryGetValue(key, out var collection))
            {
                collection.Add(value);
            }
            else
            {
                dictionary[key] = new TCollection { value };
            }
        }
    }
}
