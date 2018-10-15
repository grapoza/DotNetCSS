using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetCSS
{
    internal static class CollectionExtensions
    {
        /// <summary>
        /// Adds single items to an <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <typeparam name="T">The type of the elements in the sequence.</typeparam>
        /// <param name="target">The sequence to which elements will be concatenated.</param>
        /// <param name="items">The items to concatenate.</param>
        /// <returns>An IEnumerable including the original sequence followed by the concatenated items.</returns>
        public static IEnumerable<T> ConcatItems<T>(this IEnumerable<T> target, params T[] items)
        {
            return target.Concat(items ?? new[] { default(T) });
        }
    }
}