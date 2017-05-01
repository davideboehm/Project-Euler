using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem28
{
    class NumberSpiralDiagonals
    {
        /// <summary>
        /// Starting with the number 1 and moving to the right in a clockwise direction a 5 by 5 spiral is formed as follows:
        ///
        /// 21 22 23 24 25
        /// 20  7  8  9 10
        /// 19  6  1  2 11
        /// 18  5  4  3 12
        /// 17 16 15 14 13
        ///
        /// It can be verified that the sum of the numbers on the diagonals is 101.
        ///        /// 
        /// What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way?
        /// 
        /// Answer: 669171001
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            long size = 1001 * 1001;
            long sum = 1;
            int step = 2;
            for (int value = 1; value < size;)
            {
                for (int stepCount = 0; stepCount < 4 && value < size; stepCount++)
                {
                    value = value + step;
                    sum += value;
                }
                step+=2;
            }
            var result = sum;

        }       
    }
}
