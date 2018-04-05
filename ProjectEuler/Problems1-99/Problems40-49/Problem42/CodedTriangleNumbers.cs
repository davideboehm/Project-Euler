using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem42
{
    class CodedTriangleNumbers
    {
        /*
         *The nth term of the sequence of triangle numbers is given by, tn = ½n(n+1); so the first ten triangle numbers are:
            1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...

            By converting each letter in a word to a number corresponding to its alphabetical position and adding these values we form a word value. For example, the word value for SKY is 19 + 11 + 25 = 55 = t10. If the word value is a triangle number then we shall call the word a triangle word.

            Using words.txt (right click and 'Save Link/Target As...'), a 16K text file containing nearly two-thousand common English words, how many are triangle words? 

            Answer: 162
         */

        static void Main(string[] args)
        {
            HashSet<int> triangeNumbers = new HashSet<int>() { 1, 3, 6, 10, 15, 21, 28, 36, 45};
            var wordsText = System.IO.File.ReadAllText("Words.txt");
            var words = wordsText.Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries);
            int result = 0;
            foreach(var word in words)
            {
                var wordValue = word.ToLower().Skip(1).Take(word.Length - 2).Sum(letter => letter-'a' +1);      
                while(triangeNumbers.Last()< wordValue)
                {
                    var nextN = triangeNumbers.Count + 1;
                    var newValue = ((nextN * (nextN + 1)) / 2);
                    triangeNumbers.Add(newValue);
                }
                if(triangeNumbers.Contains(wordValue))
                {
                    result++;
                }
            }
        }
    }
}
