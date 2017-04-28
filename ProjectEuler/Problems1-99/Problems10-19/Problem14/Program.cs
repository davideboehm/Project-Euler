using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14
{
    class Program
    {
        /// <summary>
        /// The following iterative sequence is defined for the set of positive integers:
        ///
        /// n → n/2 (n is even)
        /// n → 3n + 1 (n is odd)
        ///
        /// Using the rule above and starting with 13, we generate the following sequence:
        ///
        /// 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
        /// It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
        ///
        /// Which starting number, under one million, produces the longest chain?
        ///
        /// NOTE: Once the chain starts the terms are allowed to go above one million.
        ///
        /// Answer: 837799
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ChainLengthDictionary.Add(1, 1);
            long numberProducingLargestChain = 1;
            long longestChain = 1;
            for (long i = 1; i < 1000000; i++)
            {
                var chainLength = GetChainLength(i);
                if (chainLength > longestChain)
                {
                    numberProducingLargestChain = i;
                    longestChain = chainLength;
                }
            }
        }
        private static Dictionary<long, long> ChainLengthDictionary = new Dictionary<long, long>();
        static long GetChainLength(long number)
        {
            if(ChainLengthDictionary.ContainsKey(number))
            {
                return ChainLengthDictionary[number];
            }
            var nextNumber = number;
            if((number & 1) == 0)
            {
                nextNumber = number / 2;
            }
            else
            {
                nextNumber = 3 * number + 1;
            }

            var length = 1 + GetChainLength(nextNumber);
            ChainLengthDictionary.Add(number, length);

            return length;
        }
    }
}
