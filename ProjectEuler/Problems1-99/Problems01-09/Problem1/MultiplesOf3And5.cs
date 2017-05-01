using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    using System.CodeDom;

    class MultiplesOf3And5
    {
        /// <summary>
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        /// Find the sum of all the multiples of 3 or 5 below 1000.
        /// 
        /// Answer: 233168
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var multiples = new HashSet<int>();
            var threes = Enumerable.Range(1, 999 / 3).Select(value => value * 3).ToList();
            var fives = Enumerable.Range(1, 999 / 5).Select(value => value * 5).ToList();
            multiples.UnionWith(threes);
            multiples.UnionWith(fives);
            var result = multiples.Sum();
        }
    }
}
