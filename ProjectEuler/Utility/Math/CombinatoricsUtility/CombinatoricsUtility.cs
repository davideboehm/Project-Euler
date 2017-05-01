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

        public static List<List<T>> GeneratePermutations<T>(List<T> initialItems)
        {
            List<List<T>> results;

            switch (initialItems.Count())
            {
                case 1:
                    {
                        results = new List<List<T>> { new List<T> { initialItems[0] } };
                        break;
                    }
                case 2:
                    {
                        results = new List<List<T>>
                        {
                            new List<T> { initialItems[0], initialItems[1] },

                            new List<T> { initialItems[1], initialItems[0] }
                        };
                        break;
                    }
                case 3:
                    {
                        results = new List<List<T>>
                        {
                            new List<T>(){ initialItems[0], initialItems[1], initialItems[2] },
                            new List<T>(){ initialItems[0], initialItems[2], initialItems[1] },

                            new List<T>(){ initialItems[1], initialItems[0], initialItems[2] },
                            new List<T>(){ initialItems[1], initialItems[2], initialItems[0] },

                            new List<T>(){ initialItems[2], initialItems[0], initialItems[1] },
                            new List<T>(){ initialItems[2], initialItems[1], initialItems[0] }
                        };
                        break;
                    }
                default:
                    {
                        results = new List<List<T>>();
                        for (int i = 0; i < initialItems.Count; i++)
                        {
                            var currentItem = initialItems[i];
                            var cloneInitialItems = new List<T>(initialItems);
                            cloneInitialItems.RemoveAt(i);
                            var restPermutations = GeneratePermutations<T>(cloneInitialItems);
                            foreach (var restPermutation in restPermutations)
                            {
                                restPermutation.Insert(0, currentItem);
                                results.Add(restPermutation);
                            }
                        }
                        break;
                    }
            }

            return results;
        }        
    }
}
