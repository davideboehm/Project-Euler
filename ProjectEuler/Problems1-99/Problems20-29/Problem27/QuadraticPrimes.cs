using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem27
{
    using Primes;
    class QuadraticPrimes
    {
        /// <summary>
        /// Euler discovered the remarkable quadratic formula:
        /// 
        ///     n^2+n+41
        ///     It turns out that the formula will produce 40 primes for the consecutive integer values 0≤n≤39.
        ///     However, when n=40,40^2+40+41=40(40+1)+41 is divisible by 41, and certainly when n=41,41^2+41+41 is clearly divisible by 41.
        ///     
        ///     The incredible formula n^2 -79n +1601 was discovered, which produces 80 primes for the consecutive values 0≤n≤79. The product of the coefficients, −79 and 1601, is −126479.
        ///     
        /// Considering quadratics of the form:
        /// n^2+an+b, where |a|≤999 and |b|≤1000
        /// where |n| is the modulus/absolute value of n
        /// e.g. |11|=11 and |−4|= 4
        /// Find the product of the coefficients, a and b, for the quadratic expression that produces the maximum number of primes for consecutive values of n, starting with n=0.
        /// 
        /// Answer:-59231
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var bestA = 0;
            long bestB = 0;
            var bestN = 0;
            var primes = new HashSet<long>(PrimesUtility.GetFirstXPrimes(10000));
            var bPrimes = primes.TakeWhile(prime => prime <= 1000);
            for (int a=-999;a<1000;a++)
            {
                foreach (long b in bPrimes)
                {
                    if (primes.Contains(b))
                    {
                        var n = 1;
                        while (primes.Contains(n * n + a * n + b))
                        {
                            n++;
                        }
                        if(n>bestN)
                        {
                            bestN = n;
                            bestA = a;
                            bestB = b;
                        }
                    }
                }
            }
            var result = bestA * bestB;
        }
    }
}
