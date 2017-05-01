using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    using Primes;

    class SmallestMultiple
    {
        /// <summary>
        /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        /// 
        /// Answer = 232792560
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var unreducedFactors = new List<long>()
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10,
                11,
                12,
                13,
                14,
                15,
                16,
                17,
                18,
                19,
                20
            };
            //Compute prime factorization
            var primeUnreducedFactors = new List<long>()
            {
                1,
                2,
                3,
                2 * 2,
                5,
                2 * 3,
                7,
                2 * 2 * 2,
                3 * 3,
                2 * 5,
                11,
                2 * 2 * 3,
                13,
                2 * 7,
                3 * 5,
                2 * 2 * 2 * 2,
                17,
                2 * 9,
                19,
                2 * 2 * 5
            };

            //eliminate all but the largest multiple of each prime (example: leave 16 since it is 2^4 but eliminate 2(2^1), 4 (2^2), 8(2^3) since they have less twos in their prime factorization)
            var primeReducedFactors = new List<long>()
            {
                1,
                5,
                7,
                9,
                11,
                13,
                16,
                17,
                19,
            };
            
            var result = primeReducedFactors.Aggregate(1, (long current, long value) => (current * value));
        }
    }
}
