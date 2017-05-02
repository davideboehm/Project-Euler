using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem32
{
    using CombinatoricsUtility;
    class PandigitalProducts
    {
        /// <summary>
        /// We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once; for example, the 5-digit number, 15234, is 1 through 5 pandigital.
        /// 
        /// The product 7254 is unusual, as the identity, 39 × 186 = 7254, containing multiplicand, multiplier, and product is 1 through 9 pandigital.
        /// 
        /// Find the sum of all products whose multiplicand/multiplier/product identity can be written as a 1 through 9 pandigital.
        /// 
        /// HINT: Some products can be obtained in more than one way so be sure to only include it once in your sum.
        /// 
        /// Answer: 45228
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var sum = 0;
            var seen = new HashSet<int>();
            var allPermutations = CombinatoricsUtility.GeneratePermutations(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            foreach (var permutation in allPermutations)
            {
                var firstNumber = permutation[0];
                for (int firstBreak = 1; firstBreak < 5; firstBreak++)
                {
                    firstNumber = firstNumber * 10 + permutation[firstBreak];
                    var secondNumber = permutation[firstBreak+1];
                    var thirdNumber = permutation.Skip(firstBreak + 2).Aggregate(0, (agg, current) => agg * 10 + current);
                    for (int secondBreak = firstBreak + 2; secondBreak < 8; secondBreak++)
                    {
                        if(firstNumber * secondNumber == thirdNumber && !seen.Contains(thirdNumber))
                        {
                            seen.Add(thirdNumber);
                            sum += thirdNumber;
                        }
                        secondNumber = secondNumber * 10 + permutation[secondBreak];
                        thirdNumber = permutation.Skip(secondBreak+1).Aggregate(0, (agg, current) => agg * 10 + current);
                    }
                }
            }

            var result = sum;
        }
    }
}
