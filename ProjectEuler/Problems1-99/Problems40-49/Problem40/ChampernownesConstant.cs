using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem40
{
    /*
        An irrational decimal fraction is created by concatenating the positive integers:

        0.123456789101112131415161718192021...

        It can be seen that the 12th digit of the fractional part is 1.

        If dn represents the nth digit of the fractional part, find the value of the following expression.

        d1 × d10 × d100 × d1000 × d10000 × d100000 × d1000000

        Answer: 210
     */

    class ChampernownesConstant
    {
        static void Main(string[] args)
        {
            int[] test = new int[1000001];

            int index = 0;
            for(int i=0; index< 1000001; i++)
            {
                var currentNumber = i.ToString();
                foreach(var character in currentNumber)
                {
                    test[index] = int.Parse(character+"");
                    index++;
                    if(index> 1000000)
                    {
                        break;
                    }
                }
            }
            long result = 1;

            for (int i =1;i<= 1000000;i*=10)
            {
                result *= test[i];
            }
        }   
    }
}
