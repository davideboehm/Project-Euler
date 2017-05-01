using System;
namespace MathUtility
{
    using System.Numerics;
    using DynamicUtility;
    public class MathUtility
    {
        public const decimal PHI = (sqRtOf5 + 1) / 2;
        private const decimal sqRtOf5 = 2.236067977499789696409173668731276235440618359611525724270897245410520925637804899414414408378782274969508176150773783504253267724447073863586360121533452708M;

        public static decimal Pow(decimal x, int y)
        {
            if (y == 0)
            {
                return 1;
            }
            if (y == 1)
            {
                return x;
            }
            if (y % 2 == 0)
            {
                var value = Pow(x, y / 2);
                return value * value;
            }
            else
            {
                var value = Pow(x, (y-1) / 2);
                return x * value * value;
            }
        }

        public static BigInteger Fibonacci(int sequenceNumber) => DynamicUtility.Dynamitize<int, BigInteger>(FibonacciBase)(sequenceNumber);

        private static BigInteger FibonacciBase(int sequenceNumber)
        {
            if (sequenceNumber < 0)
            {
                throw new ArgumentException("Doesn't support negative numbers");
            }
            if (sequenceNumber <= 1)
            {
                return sequenceNumber;
            }
            var result = Fibonacci(sequenceNumber - 1) + Fibonacci(sequenceNumber - 2);
            return result;
        }
    }


}
