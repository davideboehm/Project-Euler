using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes
{
    using System.Collections;

    public static class PrimesUtility
    {
        public static IEnumerable<long> GetEnumerablePrimes()
        {
            return new PrimesEnumerable();
        }
        public static IEnumerable<long> GetPrimesUpTo(long maxValue)
        {
            return PrimesEnumerable.GetPrimesUpTo(maxValue);
        }
        public static IEnumerable<long> GetFirstXPrimes(int numberOfPrimes)
        {
            return PrimesEnumerable.GetFirstXPrimes(numberOfPrimes);
        }
    }

    internal class PrimesEnumerable : IEnumerable<Int64>
    {
        private static readonly Int64 SquareRootOfInt = (Int64)Math.Sqrt(Int64.MaxValue) - 1;
        public static IEnumerable<long> GetPrimesUpTo(long maxValue)
        {
            if(knownPrimes.Last()<maxValue)
            {
                CalculatePrimesUpToValue(maxValue);
            }

            return knownPrimes.TakeWhile(prime => prime < maxValue);
        }
        public static IEnumerable<long> GetFirstXPrimes(int numberOfPrimes)
        {
            long logN = (long) Math.Log(numberOfPrimes);
            long upperBound = 2 * numberOfPrimes * logN;
            while (knownPrimes.Count < numberOfPrimes)
            {
                CalculatePrimesUpToValue(upperBound);
                upperBound *= logN;
            }

            return knownPrimes.Take(numberOfPrimes);
        }

        private static void CalculatePrimesUpToValue(long maxValue)
        {
            var result = new List<long>();
            var potentialPrimes = new bool[maxValue];
            for (int index = 2; index < maxValue; index++)
            {
                if (potentialPrimes[index] == false)
                {
                    var currentPrime = index;
                    result.Add(currentPrime);
                    for (int elimIndex = index; elimIndex < maxValue; elimIndex += currentPrime)
                    {
                        potentialPrimes[elimIndex] = true;
                    }
                }
            }

            knownPrimes = result;
        }

        public IEnumerator<Int64> GetEnumerator()
        {
            int index = 0;
            while (index < knownPrimes.Count)
            {
                yield return knownPrimes[index];
                index++;
                if (index == knownPrimes.Count)
                {
                    CalculatePrimesUpToValue(2 * knownPrimes.Last());
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        /// <summary>
        /// First 10 known primes
        /// </summary>
        private static List<Int64> knownPrimes = new List<Int64>()
        {
            2, 3, 5, 7, 11, 13, 17, 19, 23, 29
        };
    }


  
}
