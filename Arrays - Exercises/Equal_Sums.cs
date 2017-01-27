using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int? index = getIndex(nums);
            if (index != null)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        public static int? getIndex(int[] nums)
        {
            if (nums.Length == 1)
                return 0;

            int left = 0;
            int right = nums.Skip(1).Sum();
            
            for (int i = 1; i <= nums.Length; i++)
            {
                if (left == right)
                    return i - 1;

                if (i < nums.Length)
                {
                    left += nums[i - 1];
                    right -= nums[i];
                }
            }

            return null;
        }
    }
}
