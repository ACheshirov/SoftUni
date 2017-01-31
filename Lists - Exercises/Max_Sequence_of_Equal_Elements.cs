using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int lastNum = nums[0], biggestNum = nums[0];
            int lastMax = 1, biggestCount = 1;

            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] == lastNum)
                {
                    lastMax++;
                    if (lastMax > biggestCount)
                    {
                        biggestNum = lastNum;
                        biggestCount = lastMax;
                    }
                }
                else
                {
                    lastNum = nums[i];
                    lastMax = 1;
                }

            }

            Console.WriteLine(Enumerable.Repeat(biggestNum.ToString() + " ", biggestCount).Aggregate(new StringBuilder(), (sb, s) => sb.Append(s)).ToString());
        }
    }
}
