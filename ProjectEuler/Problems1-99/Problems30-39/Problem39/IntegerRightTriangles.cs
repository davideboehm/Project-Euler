using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem39
{
    class IntegerRightTriangles
    {
        /*
            If p is the perimeter of a right angle triangle with integral length sides, {a,b,c}, there are exactly three solutions for p = 120.

            {20,48,52}, {24,45,51}, {30,40,50}

            For which value of p ≤ 1000, is the number of solutions maximised? 

            Answer: 840
         */
        static void Main(string[] args)
        {
            int maxValue=0;
            int maxIValue=0;
            for(int i = 12; i<=1000; i++)
            {
                var current = CountTriangles(i);
                if (current>maxValue)
                {
                    maxValue = current;
                    maxIValue = i;
                }
            }
        }

        static int CountTriangles(int target)
        {
            int result = 0;
            for(int a =1; a<target;a++)
            {
                for (int b = 1; b < target;b++)
                {
                    double c = Math.Sqrt(a * a + b * b);
                    if(a+b+c ==target)
                    {
                        result++;
                    }
                }
            }
            return result;
        }
    }
}
