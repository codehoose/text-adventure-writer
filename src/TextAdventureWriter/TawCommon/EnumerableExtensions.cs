using System;
using System.Collections.Generic;
using System.Linq;

namespace SloanKellyGames.TawCommon
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Perform an action on each item in the enumeration.
        /// </summary>
        /// <typeparam name="T">Type.</typeparam>
        /// <param name="source">Source enumeration.</param>
        /// <param name="action">Action to perform on each item.</param>
        /// <returns>The enumeration.</returns>
        public static void Action<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
            {
                action?.Invoke(item);
            }
        }

        /// <summary>
        /// Split an enumerable list into separate arrays of items based on the given test function.
        /// </summary>
        /// <typeparam name="T">Type.</typeparam>
        /// <param name="source">Source enumeration.</param>
        /// <param name="test">Test function. Returns true if the list should be split.</param>
        /// <returns>An enumeration of arrays of T.</returns>
        public static IEnumerable<T[]> Split<T>(this IEnumerable<T> source, Func<T, bool> test)
        {
            List<T[]> arrays = new List<T[]>();
            List<T> items = new List<T>();
            foreach (var item in source)
            {
                if (!test(item))
                {
                    items.Add(item);
                }
                else
                {
                    arrays.Add(items.ToArray());
                    items.Clear();
                }
            }

            if (items.Any())
                arrays.Add(items.ToArray());

            return arrays;
        }
    }
}
