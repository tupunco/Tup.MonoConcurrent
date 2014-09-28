using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Linq
{
    /// <summary>
    /// EnumerableEx
    /// </summary>
    public static class EnumerableEx
    {
#if NET_4_0
        #region Zip

        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
        {
            if (first == null)
                throw new ArgumentNullException("first");
            if (second == null)
                throw new ArgumentNullException("second");
            if (resultSelector == null)
                throw new ArgumentNullException("resultSelector");

            return CreateZipIterator(first, second, resultSelector);
        }

        static IEnumerable<TResult> CreateZipIterator<TFirst, TSecond, TResult>(IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> selector)
        {
            using (IEnumerator<TFirst> first_enumerator = first.GetEnumerator())
            {
                using (IEnumerator<TSecond> second_enumerator = second.GetEnumerator())
                {

                    while (first_enumerator.MoveNext() && second_enumerator.MoveNext())
                    {
                        yield return selector(first_enumerator.Current, second_enumerator.Current);
                    }
                }
            }
        }

        #endregion
#endif
    }
}
