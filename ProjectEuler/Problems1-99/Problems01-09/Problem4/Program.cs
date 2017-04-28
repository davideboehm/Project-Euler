using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        /// <summary>
        /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        /// Find the largest palindrome made from the product of two 3-digit numbers.
        /// 
        /// Answer: 906609 (913 * 993)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var largestSoFar = 0;
            for (int numberOne = 999; numberOne>=100; numberOne--)
            {
                for (int numberTwo = 999; numberTwo >= 100; numberTwo--)
                {
                    var currentProduct = numberTwo * numberOne;
                    if(currentProduct> largestSoFar && isPalindrome(currentProduct) )
                    {
                        largestSoFar = currentProduct;
                    }
                }
            }
        }

        public static bool isPalindrome(int value)
        {
            return isPalindrome(value.ToString());
        }
        public static bool isPalindrome(string value)
        {
            for(int index = 0; index < value.Length/2; index ++)
            {
                if(value[index] != value[value.Length - index - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
