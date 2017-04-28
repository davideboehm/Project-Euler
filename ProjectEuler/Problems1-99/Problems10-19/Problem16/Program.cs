using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem16
{
    using System.Numerics;
    class Program
    {
        /// <summary>
        /// 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
        /// What is the sum of the digits of the number 2^1000?
        /// 
        /// Answer: 1366
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var result = 0;
            var stringNumber = BigInteger.Pow(2, 1000).ToString();
            foreach(var digit in stringNumber)
            {
                result += digit - '0';
            }
        }
    }
}
