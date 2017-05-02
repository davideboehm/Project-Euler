using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem36
{
    class Program
    {
        /// <summary>
        /// The decimal number, 585 = 10010010012 (binary), is palindromic in both bases.
        /// 
        /// Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.
        /// 
        /// (Please note that the palindromic number, in either base, may not include leading zeros.)
        /// 
        /// Answer:872187
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var sum = 0;
            for (int number = 1; number < 1000000; number++)
            {
                var binary = new BitArray(BitConverter.GetBytes(number));
                var isPalindrome = IsPalindrome(binary) && IsPalindrome(number.ToString());
                if (isPalindrome)
                {
                    sum += number;
                }
            }
            var result = sum;
        }

        static bool IsPalindrome(BitArray array)
        {
            int end = array.Length - 1;
            while (!array[end-1] && end > 0)
            {
                end--;
            }
            for (int index = 0; index < end / 2; index++)
            {
                if (!array[index].Equals(array[end - index - 1]))
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsPalindrome(string number)
        {
            for (int index = 0; index < number.Length / 2; index++)
            {
                if (!number[index].Equals(number[number.Length - index - 1]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
