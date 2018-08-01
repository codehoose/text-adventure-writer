using System.Collections.Generic;

namespace SloanKellyGames.TawCommon
{
    public static class HashSetExtensions
    {
        /// <summary>
        /// Add range.
        /// </summary>
        /// <typeparam name="T">Type.</typeparam>
        /// <param name="hashSet">Hash set.</param>
        /// <param name="source">Source.</param>
        public static void AddRange<T>(this HashSet<T> hashSet, IEnumerable<T> source)
        {
            foreach (var item in source)
            {
                hashSet.Add(item);
            }
        }
    }
}
