using System;
using System.Collections.Generic;
using System.Text;

namespace Library.WatchableTests
{
    internal static class TestInputs
    {
        internal static IEnumerable<int> IntsForTest()
        {
            yield return -1;
            yield return 0;
            yield return 1;
            yield return Int32.MaxValue;
        }

        internal static IEnumerable<string> Titles()
        {
            yield return "Star wars";
            yield return "Friday night lights";
            yield return "24";
            yield return "Friday 13th";
        }

        internal static IEnumerable<DateTime> DatesForTest()
        {
            yield return DateTime.Now;
            yield return DateTime.Now.AddDays(1);
            yield return DateTime.MaxValue;
            yield return DateTime.MinValue;
        }
    }
}
