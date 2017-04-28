
namespace Problem15
{
    using CombinatoricsUtility;
    class Program
    {
        /// <summary>
        /// Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
        /// How many such routes are there through a 20×20 grid?
        /// Answer: 137846528820
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var result = CombinatoricsUtility.NChooseK(40, 20);
        }
    }
}
