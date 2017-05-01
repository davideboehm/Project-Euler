using System;
using System.Collections.Generic;

namespace LongUtility
{
    using System.Collections;

    public class LongUtility
    {

    }

    public static class LongEnumerable
    {
        public static IEnumerable<Int64> Range(long start, long count)
        {
            return new LongEnumerableInstance().Range(start, count);
        }

        private class LongEnumerableInstance : IEnumerable<long>
        {
            public IEnumerator<long> GetEnumerator()
            {
                for (long value = 0; value < long.MaxValue; value++)
                {
                    yield return value;
                }
                throw new IndexOutOfRangeException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }

            public IEnumerable<Int64> Range(long start, long count)
            {
                for (long value = start; value < start + count; value++)
                {
                    yield return value;
                }
            }
        }
    }
}
