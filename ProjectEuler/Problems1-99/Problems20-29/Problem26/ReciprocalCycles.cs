﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem26
{
    using MathUtility;
    using System.Numerics;
    class ReciprocalCycles
    {        
        /// <summary>
        /// A unit fraction contains 1 in the numerator. The decimal representation of the unit fractions with denominators 2 to 10 are given:
        /// 1/2	= 	0.5
        /// 1/3	= 	0.(3)
        /// 1/4	= 	0.25
        /// 1/5	= 	0.2
        /// 1/6	= 	0.1(6)
        /// 1/7	= 	0.(142857)
        /// 1/8	= 	0.125
        /// 1/9	= 	0.(1)
        /// 1/10	= 	0.1
        /// Where 0.1(6) means 0.166666..., and has a 1-digit recurring cycle.It can be seen that 1/7 has a 6-digit recurring cycle.
        /// 
        /// Find the value of d less than 1000 for which 1/d contains the longest recurring cycle in its decimal fraction part.
        /// 
        /// Answer: 983
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int valueOfD = 0;
            BigInteger longestRepeat = 0;
            for(int d=1;d<1000;d++)
            {
                var currentFraction = new Fraction(1, d);
                if(currentFraction.repeatingDecimal.Length > longestRepeat)
                {
                    longestRepeat = currentFraction.repeatingDecimal.Length;
                    valueOfD = d;
                }
            }

            var result = valueOfD;
        }
    }
}
