using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem33
{
    using MathUtility;
    class DigitCancellingFractions
    {
        /// <summary>
        /// /// The fraction 49/98 is a curious fraction, as an inexperienced mathematician in attempting to simplify it may incorrectly believe that 49/98 = 4/8, which is correct, is obtained by cancelling the 9s.
        /// 
        /// We shall consider fractions like, 30/50 = 3/5, to be trivial examples.
        /// 
        /// There are exactly four non-trivial examples of this type of fraction, less than one in value, and containing two digits in the numerator and denominator.
        /// 
        /// If the product of these four fractions is given in its lowest common terms, find the value of the denominator.
        /// 
        /// Answer: 100
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var totalNumerator = 1;
            var totalDenominator = 1;
            for(int commonDigit = 1; commonDigit<10; commonDigit++)
            {
                for (int secondDigit = 0; secondDigit < 10; secondDigit++)
                {
                    for (int thirdDigit = 9; thirdDigit > secondDigit; thirdDigit--)
                    {
                        double numerator = secondDigit * 10 + commonDigit;
                        double denominator = commonDigit * 10 + thirdDigit;
                        
                        if(numerator / denominator == (double) secondDigit / thirdDigit)
                        {
                            totalNumerator *= secondDigit;
                            totalDenominator *= thirdDigit;
                        }
                    }
                }
            }
            var result = new Fraction(totalNumerator, totalDenominator).Simplify().denominator;
        }
    }
}