using System;
using System.Collections.Generic;

namespace LongUtility
{
    using System.Collections;

    public class LongUtility
    {
        public static IEnumerator<long> GetEnumerator()
        {
            for (long value = 0; value < long.MaxValue; value++)
            {
                yield return value;
            }
        }
        
        public static IEnumerable<Int64> Range(long start, long count)
        {
            for (long value = start; value < start + count; value++)
            {
                yield return value;
            }
        }
    }
}
