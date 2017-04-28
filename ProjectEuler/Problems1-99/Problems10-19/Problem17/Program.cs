using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17
{
    class Program
    {/// <summary>
     /// If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
     ///
     /// If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
     ///
     /// NOTE: Do not count spaces or hyphens.For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters.The use of "and" when writing out numbers is in compliance with British usage.
     ///      
     /// Answer: 21124
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            var result = 0;
            for(int i=1; i<=1000; i++)
            {
                result += GetWrittenOutNumber(i).Length;
            }

        }
        static string GetWrittenOutNumber(int number)
        {
            if(number == 1000)
            {
                return "onethousand";
            }
            return GetWrittenOut100(number);
        }

        private static string GetWrittenOut100(int number)
        {
            var result = "";
            var leadingNumber = number / 100;
            var remaingNumber = number % 100;
            if (leadingNumber > 0)
            {
                result = GetWrittenOut1(leadingNumber) + "hundred";
                if (remaingNumber != 0)
                {
                    result += "and" + GetWrittenOut10(number % 100);
                }
            }
            else
            {
                result = GetWrittenOut10(number % 100);
            }

            return result;
        }
        private static string GetWrittenOut10(int number)
        {
            var answer = "";
            if(number<10)
            {
                return GetWrittenOut1(number);
            }
            else if(number<20)
            {
                switch(number)
                {
                    case 10:
                        {
                            return "ten";
                        }
                    case 11:
                        {
                            return "eleven";
                        }
                    case 12:
                        {
                            return "twelve";
                        }
                    case 13:
                        {
                            return "thirteen";
                        }
                    case 14:
                        {
                            return "fourteen";
                        }
                    case 15:
                        {
                            return "fifteen";
                        }
                    case 16:
                        {
                            return "sixteen";
                        }
                    case 17:
                        {
                            return "seventeen";
                        }
                    case 18:
                        {
                            return "eighteen";
                        }
                    case 19:
                        {
                            return "nineteen";
                        }
                }
            }
            else if(number<30)
            {
                answer =  "twenty";
            }
            else if (number < 40)
            {
                answer = "thirty";
            }
            else if (number < 50)
            {
                answer = "fourty";
            }
            else if (number < 60)
            {
                answer = "fifty";
            }
            else if (number < 70)
            {
                answer = "sixty";
            }
            else if (number < 80)
            {
                answer = "seventy";
            }
            else if (number < 90)
            {
                answer = "eighty";
            }
            else if (number < 100)
            {
                answer = "ninety";
            }
            return answer + GetWrittenOut1(number % 10);
        }
        private static string GetWrittenOut1(int number)
        {
            switch(number)
            {
                case 1:
                    {
                        return "one";
                    }
                case 2:
                    {
                        return "two";
                    }
                case 3:
                    {
                        return "three";
                    }
                case 4:
                    {
                        return "four";
                    }
                case 5:
                    {
                        return "five";
                    }
                case 6:
                    {
                        return "six";
                    }
                case 7:
                    {
                        return "seven";
                    }
                case 8:
                    {
                        return "eight";
                    }
                case 9:
                    {
                        return "nine";
                    }
            }
            return "";
        }
    }
}
