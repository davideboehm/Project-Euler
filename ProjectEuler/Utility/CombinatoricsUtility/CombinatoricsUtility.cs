using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinatoricsUtility
{
    public static class CombinatoricsUtility
    {
        public static long NChooseK(int n, int k)
        {
            var result = 1.0;
            for(int i= 1; i<=k;i++)
            {
                result *= (n + 1 - i) / (double) i;
            }
            return (long) result;
        }
    }
}
