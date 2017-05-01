using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    class SpecialPythagoreanTriplet
    {
        /// <summary>
        /// A Pythagorean triplet is a set of three natural numbers, a less than b  less than c, for which,
        /// a^2 + b^2 = c^2
        /// For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
        /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        /// Find the product abc.
        /// 
        /// Answer: 31875000
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var result = FindPythTripleProduct();
        }

        public static long FindPythTripleProduct()
        {
            // (1) a < b < c   Given
            // (2) a + b + c  = 1000   Given

            // a's limit
            // (3) a + a + a < 1000  follows directly from (2) using (1) for the replacements 
            // (4) a < 333 simplify (3)

            // b's limit
            // (5) b + c = (1000 - a) rewrite of (2)
            // (6) b + b  < (1000-a)  since  b < c && (5)  
            // (7) b < (1000 -a) /2  simplify (6)

            
            for (int a = 1; a < 333; a++)
            {
                for (int b = a + 1; b < (1000 - a) / 2; b++)
                {
                    int c = 1000 - (a + b);
                    if (c > b && (a * a + b * b) == c * c)
                    {
                        return a * b * c;
                    }
                }
            }
            return 0;
        }
    }
}
