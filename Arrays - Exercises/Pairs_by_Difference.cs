using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());

            int counts = 0;
            for (int i1 = 0; i1 < nums.Length; i1++)
            {
                for (int i2 = i1 + 1; i2 < nums.Length; i2++)
                {
                    if (Math.Abs(nums[i1] - nums[i2]) == diff)
                    {
                        counts++;
                    }
                }
            }
            Console.WriteLine(counts);
        }
    }
}
