using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem34
{
    using DynamicUtility;
    class DigitFactorials
    {
        /// <summary>
        /// 145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
        /// 
        /// Find the sum of all numbers which are equal to the sum of the factorial of their digits.
        /// 
        /// Note: as 1! = 1 and 2! = 2 are not sums they are not included.
        /// 
        /// Answer: 40730
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            long totalSum = 0;
            var max = Factorial(9)*2;
            for(int curentNumber =3; curentNumber < max; curentNumber++)
            {
                var currentValue = curentNumber;
                long currentSum = 0;
                while(currentValue > 0)
                {
                    currentSum += Factorial(currentValue % 10);
                    currentValue /= 10;
                }
                if(currentSum == curentNumber)
                {
                    totalSum += curentNumber;
                }
            }
            var result = totalSum;

        }
        static long Factorial(int value) => DynamicUtility.Dynamitize<int,long>(FactorialBase)(value);
        private static long FactorialBase(int value)
        {
            var result = 1;
            for(int i =2; i<=value; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
