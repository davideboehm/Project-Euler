using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem67
{
    class Program
    {
        /// <summary>
        /// 
        /// By starting at the top of the triangle below and moving to adjacent numbers on the row below, the maximum total from top to bottom is 23.
        ///    3
        ///   7 4
        ///  2 4 6
        /// 8 5 9 3
        ///
        /// That is, 3 + 7 + 4 + 9 = 23.
        ///
        /// Find the maximum total from top to bottom in triangle.txt(right click and 'Save Link/Target As...'), a 15K text file containing a triangle with one-hundred rows.
        ///
        /// NOTE: This is a much more difficult version of Problem 18. It is not possible to try every route to solve this problem, as there are 299 altogether! 
        /// If you could check one trillion (1012) routes every second it would take over twenty billion years to check them all.There is an efficient algorithm to solve it. ; o)
        /// 
        /// 
        /// Answer: 7273
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var valuesText = System.IO.File.ReadAllText("triangle.txt");
            var values = valuesText.Split(new char[]{ '\n','\r'}, StringSplitOptions.RemoveEmptyEntries);
            var pathValues = new int[100, 100];
            
            for (int i = 99; i >= 0; i--)
            {
                var numbers = values[i].Split(' ');
                for (int j = 0; j <= i; j++)
                {
                    var potentialValue = 0;
                    if (i + 1 < 100)
                    {
                        potentialValue = Math.Max(potentialValue, pathValues[i + 1, j]);
                        if (j + 1 < 100)
                        {
                            potentialValue = Math.Max(potentialValue, pathValues[i + 1, j + 1]);
                        }
                    }

                    pathValues[i, j] = potentialValue + int.Parse(numbers[j]);
                }
            }
            var result = pathValues[0, 0];
        }
    }
}
