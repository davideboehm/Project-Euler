using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    using Primes;

    class SummationOfPrimes
    {
        /// <summary>
        /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
        /// Find the sum of all the primes below two million.
        /// 
        /// Answer: 142913828922
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var result = PrimesUtility.GetPrimesUpTo(2000000).Sum();
        }
    }
}
