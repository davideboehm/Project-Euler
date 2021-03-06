﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    using System.Runtime.CompilerServices;
    using LongUtility;

    class SumSquareDifference
    {
        /// <summary>
        /// The sum of the squares of the first ten natural numbers is,
        /// 1^2 + 2^2 + ... + 10^2 = 385
        /// The square of the sum of the first ten natural numbers is,
        /// (1 + 2 + ... + 10)^2 = 55^2 = 3025
        /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
        /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        /// 
        /// Answer: 25164150
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 100).ToList();
            var sum = numbers.Sum();
            var squareOfSum = sum * sum;
            long sumOfSquares = numbers.Select(value => value * value).Sum();

            var result = squareOfSum - sumOfSquares;
        }
    }
}
