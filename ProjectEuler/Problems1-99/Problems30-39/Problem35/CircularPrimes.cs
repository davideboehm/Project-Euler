using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem35
{
    using CombinatoricsUtility;
    using Primes;
    class CircularPrimes
    {
        /// <summary>
        /// The number, 197, is called a circular prime because all rotations of the digits: 197, 971, and 719, are themselves prime.

        /// There are thirteen such primes below 100: 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.

        /// How many circular primes are there below one million?      
        /// 
        /// Answer: 55
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int count = 2;
            var list = new List<long>() { 2, 5 };
            var primesToCycle = PrimesUtility.GetPrimesUpTo(1000000)
                                             .Select(prime=>prime.ToString().ToList())
                                             .Where(digitList=> digitList.All(digit=> (digit-'0')%2 !=0 && (digit - '0')!=5));
            
            var primes = new HashSet<long>(PrimesUtility.GetPrimesUpTo(1000000));

            foreach (var prime in primesToCycle)
            {
                var rotations = CombinatoricsUtility.GenerateRotations(prime);
                var isCircularPrime = true;
                foreach (var rotation in rotations)
                {
                   var primeCandidate = rotation.Aggregate(0, (agg, current) => agg *10 + (current - '0'));
                    if(!primes.Contains(primeCandidate))
                    {
                        isCircularPrime = false;
                        break;
                    }
                }
                if(isCircularPrime)
                {
                    list.Add(prime.Aggregate(0, (agg, current) => agg * 10 + (current - '0')));
                    count++;
                }
            }
            var result = count;
        }
    }
}
