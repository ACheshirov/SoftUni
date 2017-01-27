using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxStartIndex = 0;
            int maxEndIndex = 0;

            int indexNow = 0;
            int maxCountRow = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] - nums[i - 1] > 0)
                {
                    if (i - indexNow > maxCountRow)
                    {
                        maxCountRow = i - indexNow;
                        maxStartIndex = indexNow;
                        maxEndIndex = i;
                    }
                }
                else
                {
                    indexNow = i;
                }
            }

            for (int n = maxStartIndex; n <= maxEndIndex; n++)
            {
                Console.Write(nums[n] + " ");
            }
        }
    }
}
