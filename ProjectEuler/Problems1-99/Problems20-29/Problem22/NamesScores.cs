using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem22
{
    class NamesScores
    {
        /// <summary>
        /// Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.
        /// 
        /// For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list.So, COLIN would obtain a score of 938 × 53 = 49714.
        /// 
        /// 
        /// What is the total of all the name scores in the file?
        /// 
        /// Answer: 871198282
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var valuesText = System.IO.File.ReadAllText("names.txt");
            var values = valuesText.Split(new char[] { ',', '"' }, StringSplitOptions.RemoveEmptyEntries);
            var sortedList = values.ToList();
            sortedList.Sort();
            var sum = 0;
            for(int position = 0; position< sortedList.Count(); position++)
            {
                var name = sortedList[position];
                var value = 0;
                foreach(char character in name)
                {
                    value += (character - 'A' +1) ; 
                }
                sum += value * (position + 1);

            }
            var result = sum;
        }
    }
}
