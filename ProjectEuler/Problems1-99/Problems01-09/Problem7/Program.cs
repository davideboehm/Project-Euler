using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    using Primes;

    class Program
    {
        /// <summary>
        /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        /// What is the 10 001st prime number?
        /// 
        /// Answer : 104743
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var result = PrimesUtility.GetFirstXPrimes(10001).Last();

        }
    }
}
