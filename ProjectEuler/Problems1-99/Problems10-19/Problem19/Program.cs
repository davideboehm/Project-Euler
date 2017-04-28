using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem19
{
    class Program
    {
        /// <summary>
        /// You are given the following information, but you may prefer to do some research for yourself.
        /// 
        /// 1 Jan 1900 was a Monday.
        /// Thirty days has September,
        /// April, June and November.
        /// All the rest have thirty-one,
        /// Saving February alone,
        ///  Which has twenty-eight, rain or shine.
        /// And on leap years, twenty-nine.
        ///  A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
        ///  How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
        ///  
        /// Answer: 171
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            DateTime start = new DateTime(1901, 1, 1);
            var end = new DateTime(2000, 12, 31);
            var currentDay = start;
            int count = 0;
            
            while(currentDay < end)
            {
                if(currentDay.DayOfWeek == DayOfWeek.Sunday)
                {
                    count++;
                }
                currentDay = currentDay.AddMonths(1);
            }
            var result = count;
        }
    }
}
