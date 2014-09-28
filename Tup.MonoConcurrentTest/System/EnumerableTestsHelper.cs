using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MonoTests.System
{
    /// <summary>
    /// Enumerable Tests Helper
    /// </summary>
    static class EnumerableTestsHelper
    {
        /// <summary>
        /// 列表 每项都不为 NULL
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="actual"></param>
        public static void AreIsAllNotNull<T>(this IEnumerable<T> actual)
        {
            Assert.IsNotNull(actual);

            foreach (var item in actual)
            {
                Assert.IsNotNull(item);
            }
        }
        /// <summary>
        /// 无序 列表比对 相等与否
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="actual"></param>
        /// <param name="expected"></param>
        /// <param name="msg"></param>
        public static void AreCollectionEquivalent<T>(this IEnumerable<T> actual, IEnumerable<T> expected, string msg = "")
        {
            Assert.IsNotNull(actual);
            Assert.IsNotNull(expected);

            var actualList = actual.ToList();
            var expectedList = expected.ToList();

            foreach (var item in expectedList)
            {
                Assert.IsTrue(actualList.Contains(item));
                actualList.Remove(item);
            }
            if (actualList.Any())
                Assert.Fail("Unexpected element: " + actualList.Count);
        }

        /// <summary>
        /// 有序 列表比对 相等与否
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expected"></param>
        /// <param name="actual"></param>
        public static void AreEqual<T>(this IEnumerable<T> expected, IEnumerable<T> actual, string msg = "")
        {
            if (expected == null)
            {
                Assert.IsNull(actual);
                return;
            }

            Assert.IsNotNull(actual);
            int index = -1;

            IEnumerator<T> ee = expected.GetEnumerator();
            IEnumerator<T> ea = actual.GetEnumerator();

            while (ee.MoveNext())
            {
                Assert.IsTrue(ea.MoveNext(), "'" + ee.Current + "' expected at index '" + ++index + "'.");
                Assert.AreEqual(ee.Current, ea.Current, "at index '" + index + "'");
            }

            if (ea.MoveNext())
                Assert.Fail("Unexpected element: " + ea.Current);
        }
        /*
         CollectionEquivalentConstraint
EqualConstraint
         */
    }
}
