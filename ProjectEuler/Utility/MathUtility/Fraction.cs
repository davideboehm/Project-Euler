using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtility
{
    using System.Numerics;
    public class Fraction
    {
        public readonly string integerPart = "";
        public readonly string nonRepeatingDecimal = "";
        public readonly string repeatingDecimal = "";
        public readonly long numerator;
        public readonly long denominator;
        private const int repeatLimit = 2000;
        public Fraction(long numerator, long denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            integerPart = (numerator / denominator).ToString();
            long currentValue = (numerator % denominator) * 10;
            var divisionsSeen = new HashSet<(long, long)>();
            Queue<(long, long, string)> digits = new Queue<(long, long, string)>();
            for (int i = 0; i < repeatLimit; i++)
            {
                if (currentValue == 0)
                {
                    nonRepeatingDecimal = string.Concat(digits.Select((tuple) => tuple.Item3));
                    break;
                }
                else if (currentValue < denominator)
                {
                    digits.Enqueue((currentValue, denominator, (currentValue / denominator).ToString()));
                    currentValue *= 10;
                }
                else
                {
                    var StopDigit = (currentValue / denominator).ToString();
                    if (divisionsSeen.Contains((currentValue, denominator)))
                    {
                        (long numerator, long denominator, string digit) currentDigit;
                        for (currentDigit = digits.Dequeue(); digits.Any() && !currentDigit.Equals((currentValue, denominator, StopDigit)); currentDigit = digits.Dequeue())
                        {
                            nonRepeatingDecimal = string.Concat(nonRepeatingDecimal, currentDigit.digit);
                        }
                        repeatingDecimal = string.Concat(repeatingDecimal, currentDigit.digit);
                        while (digits.Any())
                        {
                            currentDigit = digits.Dequeue();
                            repeatingDecimal = string.Concat(repeatingDecimal, currentDigit.digit);
                        }
                        break;
                    }
                    digits.Enqueue((currentValue, denominator, StopDigit));
                    divisionsSeen.Add((currentValue, denominator));
                    currentValue = (currentValue % denominator) * 10;
                }
            }
        }

    }
}
