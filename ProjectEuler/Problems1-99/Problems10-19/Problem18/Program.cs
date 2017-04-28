using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem18
{
    class Program
    {
        /// <summary>
        /// By starting at the top of the triangle below and moving to adjacent numbers on the row below, the maximum total from top to bottom is 23.
        ///
        ///    3
        ///   7 4
        ///  2 4 6
        /// 8 5 9 3
        ///
        /// That is, 3 + 7 + 4 + 9 = 23.
        ///
        /// Find the maximum total from top to bottom of the triangle below:
        ///
        ///               75
        ///              95 64
        ///             17 47 82
        ///            18 35 87 10
        ///           20 04 82 47 65
        ///          19 01 23 75 03 34
        ///         88 02 77 73 07 63 67
        ///        99 65 04 28 06 16 70 92
        ///       41 41 26 56 83 40 80 70 33
        ///      41 48 72 33 47 32 37 16 94 29
        ///     53 71 44 65 25 43 91 52 97 51 14
        ///    70 11 33 28 77 73 17 78 39 68 17 57
        ///   91 71 52 38 17 14 91 43 58 50 27 29 48
        ///  63 66 04 68 89 53 67 30 73 16 69 87 40 31
        /// 04 62 98 27 23 09 70 98 73 93 38 53 60 04 23
        ///
        /// NOTE: As there are only 16384 routes, it is possible to solve this problem by trying every route. However, Problem 67, is the same challenge with a triangle containing one-hundred rows; it cannot be solved by brute force, and requires a clever method! ;o)
        /// 
        /// Answer: 1074
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[,] numbers = new int[15, 15]{
                { 75, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 95,64, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 17,47,82, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 18,35,87,10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 20,04,82,47,65, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 19,01,23,75,03,34, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 88,02,77,73,07,63,67, 0, 0, 0, 0, 0, 0, 0, 0},
                { 99,65,04,28,06,16,70,92, 0, 0, 0, 0, 0, 0, 0},
                { 41,41,26,56,83,40,80,70,33, 0, 0, 0, 0, 0, 0},
                { 41,48,72,33,47,32,37,16,94,29, 0, 0, 0, 0, 0},
                { 53,71,44,65,25,43,91,52,97,51,14, 0, 0, 0, 0},
                { 70,11,33,28,77,73,17,78,39,68,17,57, 0, 0, 0},
                { 91,71,52,38,17,14,91,43,58,50,27,29,48, 0, 0},
                { 63,66,04,68,89,53,67,30,73,16,69,87,40,31, 0},
                { 04,62,98,27,23,09,70,98,73,93,38,53,60,04,23}
            };

            int[,] pathValues = new int[15, 15];

            for (int i = 14; i >=0 ; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    var potentialValue = 0;
                    if (i + 1 < 15)
                    {
                        potentialValue = Math.Max(potentialValue, pathValues[i + 1, j ]);
                        if (j + 1 < 15)
                        {
                            potentialValue = Math.Max(potentialValue, pathValues[i + 1, j + 1]);
                        }                        
                    }

                    pathValues[i, j] = potentialValue + numbers[i, j];
                }
            }
            var result = pathValues[0, 0];
        }
    }
}
