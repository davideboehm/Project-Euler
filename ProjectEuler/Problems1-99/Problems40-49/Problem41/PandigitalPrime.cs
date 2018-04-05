using Primes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem41
{
    class PandigitalPrime
    {
        //We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once. For example, 2143 is a 4-digit pandigital and is also prime.
        //What is the largest n-dsigit pandigital prime that exists?
        //Answer:7652413
        static void Main(string[] args)
        {
            long currentMax = 2143;
            var primes = PrimesUtility.GetPrimesUpTo(100);
            foreach (var prime in primes)
            {
                var primeString = prime.ToString();
                if (primeString.Length == primeString.Distinct().Count())
                {
                    var isPandigital = true;
                    for(int i =1; i<=primeString.Length;i++)
                    {
                        if(primeString.IndexOf(i.ToString()[0])==-1)
                        {
                            isPandigital = false;
                            break;
                        }
                    }
                    if(isPandigital && prime > currentMax)
                    {
                        currentMax = prime;
                    }
                }
            }
        }
    }
}
