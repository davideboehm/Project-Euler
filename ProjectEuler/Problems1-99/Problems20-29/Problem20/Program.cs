using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem20
{
    class Program
    {
        /// <summary>
        /// n! means n × (n − 1) × ... × 3 × 2 × 1
        ///
        /// For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
        /// and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
        ///
        /// Find the sum of the digits in the number 100!
        /// 
        /// Answer: 648
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var value = new BigInteger(1);
            for (int i = 0; i < 100; i++)
            {
                value *= i;
            }
            var valueAsString = value.ToString();
            var result = valueAsString.Sum(digit => digit - '0');

        }
    }
}
