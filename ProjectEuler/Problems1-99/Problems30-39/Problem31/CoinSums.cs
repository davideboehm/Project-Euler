using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem31
{
    class CoinSums
    {
        /// <summary>
        /// In England the currency is made up of pound, £, and pence, p, and there are eight coins in general circulation:
        /// 
        /// 1p, 2p, 5p, 10p, 20p, 50p, £1 (100p) and £2 (200p).
        /// It is possible to make £2 in the following way:
        /// 
        /// 1×£1 + 1×50p + 2×20p + 1×5p + 1×2p + 3×1p
        /// How many different ways can £2 be made using any number of coins?
        /// 
        /// Answer: 73682
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var result = waysToMakeValue(new List<int>() { 1, 2, 5, 10, 20, 50, 100, 200 }, 200);

        }       

        static int waysToMakeValue(List<int> coinValues, int target)            
        {
            if (coinValues.Count == 1)
            {
                if ((coinValues[0] <= target || target == 0) && target % coinValues[0] == 0)
                {
                    return 1;
                }
                return 0;
            }

            int totalNumberOfWays = 0;         
            var currentCoinValue = coinValues[coinValues.Count-1];
            var otherCoins = new List<int>(coinValues);
            otherCoins.RemoveAt(coinValues.Count - 1);
            for (int currentTarget = target; currentTarget >= 0; currentTarget -= currentCoinValue)
            {
                totalNumberOfWays += waysToMakeValue(otherCoins, currentTarget);
            }

            return totalNumberOfWays;
        }
    }
}
