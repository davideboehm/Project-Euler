using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem38
{
    class PandigitalMultiples
    {
        /*          
            Take the number 192 and multiply it by each of 1, 2, and 3:
            192 × 1 = 192
            192 × 2 = 384
            192 × 3 = 576
            By concatenating each product we get the 1 to 9 pandigital, 192384576. We will call 192384576 the concatenated product of 192 and (1,2,3)

            The same can be achieved by starting with 9 and multiplying by 1, 2, 3, 4, and 5, giving the pandigital, 918273645, which is the concatenated product of 9 and (1,2,3,4,5).

            What is the largest 1 to 9 pandigital 9-digit number that can be formed as the concatenated product of an integer with (1,2, ... , n) where n > 1?
           
            Answer: 932718654
        
        */

        static void Main(string[] args)
        {
            long currentMax = 918273645;
            var numbers = new List<int> { 9, 8, 7, 6, 5, 4, 3, 2, 1};

            foreach (var currentCombo in GetCombinations(numbers))
            {                
                var currentString = currentCombo.ToString();
                for(int i =2; i<=10; i++)
                {
                    currentString = currentString + (currentCombo * i).ToString();
                    if (currentString.Length != currentString.Distinct().Count() || currentString.Length > 9)
                    {
                        break;
                    }

                    var currentNumber = long.Parse(currentString);
                   
                    if (currentString.Length ==9 && currentNumber>=currentMax && !currentString.Contains("0"))
                    {
                        currentMax = currentNumber;
                        break;
                    }
                }
            }
        }
        
        static IEnumerable<int> GetCombinations(List<int> values)
        {
            for(int i =1; i< values.Count; i++)
            {
                foreach(var result in GetCombinations(values, i))
                {
                    yield return result;
                }
            }
        }

        static IEnumerable<int> GetCombinations(List<int> values, int choose)
        {
            if (choose > 0)
            {
                var valuesCopy = new List<int>(values);
                foreach (var value in values)
                {
                    var result = value;

                    if (choose > 1)
                    {
                        valuesCopy.Remove(value);

                        foreach (var nextValues in GetCombinations(valuesCopy, choose - 1))
                        {
                            yield return result + 10 * nextValues;
                        }

                        valuesCopy.Add(value);
                    }
                    else
                    {
                        yield return result;
                    }
                }
            }
        }
    }
}
