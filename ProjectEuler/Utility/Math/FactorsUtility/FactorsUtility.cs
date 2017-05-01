

namespace FactorsUtility
{
    using System;
    using System.Collections.Generic;
    using LongUtility;
    using System.Linq;
    using Primes;

    public static class FactorsUtility
    {
        public static List<int> GetProperFactors(int number)
        {
            var result = GetFactors(number);
            result.RemoveAt(result.Count - 1);
            return result;
        }
        public static List<int> GetFactors(int number)
        {
            var max = (int)Math.Sqrt(number) +1 ;
            var potentialFactors = Enumerable.Range(1, max);
            var result = new List<int>();
            for(int i = 1; i< max; i++)
            {
                var quotient = Math.DivRem(number, i, out int remainder);
                if(remainder == 0)
                {
                    result.Add(quotient);
                    if (quotient != i)
                    {
                        result.Add(i);
                    }
                }
            }
            result.Sort();

            return result;
        }

        public static List<(int, int)> GetPrimeFactors(int number)
        {
            var result = new List<(int factor, int count)>();
            var potentialFactors = PrimesUtility.GetPrimesUpTo(number+1);
            foreach(var prime in potentialFactors)
            {
                int count = 0;
                while(number % prime ==0)
                {
                    number = number / (int)prime;
                    count++;
                }
                if (count > 0)
                {
                    result.Add((factor: (int)prime, count: count));
                }
                if(number == 1)
                {
                    return result;
                }
            }
            return result;
            
        }
    }
}
