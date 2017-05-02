using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Collections;

namespace MathUtility.Numerics
{
    public class DigitableInt :IEnumerable<int>
    {
        public static implicit operator BigInteger(DigitableInt current)
        {
            return current.Value;
        }
        public static implicit operator DigitableInt (BigInteger current)
        {
            return new DigitableInt(current);
        }
        public static implicit operator List<int>(DigitableInt current)
        {
            return current.digits.ToList();
        }

        public DigitableInt(BigInteger value)
        {
            this.Value = value;
        }
        public DigitableInt(List<char> value)
        {
            this.Value = value.Aggregate(BigInteger.Zero, (agg, current) => agg + (current - '0'));
        }
        private BigInteger value;
        private BigInteger Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
                this.digits = value.ToString().Select(character => character - '0').ToArray();
            }
        }
        int[] digits;
        public int this[int index] { get => digits[index]; }

        public int Count => digits.Length;

        public IEnumerator<int> GetEnumerator()
        {
            for(int i =0; i< this.Count; i++)
            {
                yield return digits[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
