using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    using Primes;

    class Program
    {
        /// <summary>
        /// The prime factors of 13195 are 5, 7, 13 and 29.
        /// What is the largest prime factor of the number 600851475143 ?
        /// 
        /// Answer: 6857
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var start = (long) Math.Sqrt(600851475143);
            var primes = PrimesUtility.GetPrimesUpTo(start);
            var result = primes.Reverse().First(prime => 600851475143 % prime == 0);
        }
    }
}
