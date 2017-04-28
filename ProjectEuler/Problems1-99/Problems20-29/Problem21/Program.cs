using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem21
{
    using FactorsUtility;
    class Program
    {
        /// <summary>
        /// Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
        /// If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.
        /// 
        /// For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.
        /// 
        /// Evaluate the sum of all the amicable numbers under 10000.
        /// 
        /// Answer: 31626
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var sumDictionary = new Dictionary<int, int>();
            var amicableNumbers = new List<int>();
            for (int i = 1; i < 10000; i++)
            {
                sumDictionary.Add(i, FactorsUtility.GetFactors(i).Sum() - i);
            }
            for (int i = 1; i < 10000; i++)
            {
                if (sumDictionary.ContainsKey(sumDictionary[i]) &&
                  (i == sumDictionary[sumDictionary[i]]) &&
                  (i != sumDictionary[i]))
                {
                    amicableNumbers.Add(i);
                }
            }
            var result = amicableNumbers.Sum();
        }
    }
}
