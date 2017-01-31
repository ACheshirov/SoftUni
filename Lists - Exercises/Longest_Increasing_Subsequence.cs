using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] len = new int[nums.Count];
            int[] prev = new int[nums.Count];

            int maxLen = 0;
            int lastIndex = -1;

            for (int i = 0; i < nums.Count; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                for (int i2 = 0; i2 < i; i2++)
                {
                    if (nums[i2] < nums[i] && (len[i2] + 1) > len[i])
                    {
                        len[i] = len[i2] + 1;
                        prev[i] = i2;
                    }
                }

                if (len[i] > maxLen)
                {
                    maxLen = len[i];
                    lastIndex = i;
                }
            }

            List<int> longestSeq = new List<int>();

            while (lastIndex != -1)
            {
                longestSeq.Add(nums[lastIndex]);
                lastIndex = prev[lastIndex];
            }

            longestSeq.Reverse();

            Console.WriteLine(string.Join(" ", longestSeq));
        }
    }
}
