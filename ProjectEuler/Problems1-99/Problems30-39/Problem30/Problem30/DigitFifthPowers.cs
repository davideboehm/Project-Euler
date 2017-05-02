using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem30
{
    class DigitFifthPowers
    {
        /// <summary>
        /// Surprisingly there are only three numbers that can be written as the sum of fourth powers of their digits:
        /// 
        /// 1634 = 1^4 + 6^4 + 3^4 + 4^4
        /// 8208 = 8^4 + 2^4 + 0^4 + 8^4
        /// 9474 = 9^4 + 4^4 + 7^4 + 4^4
        /// As 1 = 1^4 is not a sum it is not included.
        /// 
        /// The sum of these numbers is 1634 + 8208 + 9474 = 19316.
        /// 
        /// Find the sum of all the numbers that can be written as the sum of fifth powers of their digits.
        /// 
        /// Answer: 443839
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            long sum = 0;
            long min = (long) Math.Pow(2, 5);
            long max = (long) Math.Pow(9, 5) * 5;
            for(long currentNumber = min; currentNumber < max; currentNumber++)
            {
                string currentNumberString = currentNumber.ToString();
                long value = (long)currentNumberString.Select(currentDigit => Math.Pow((currentDigit - '0'), 5)).Sum();
                if(value == currentNumber)
                {
                    sum += currentNumber;
                }
            }
            var result = sum;
        }
    }
}
