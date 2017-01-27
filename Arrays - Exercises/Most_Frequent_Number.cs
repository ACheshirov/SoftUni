using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] nums = Console.ReadLine().Split(' ').Select(ushort.Parse).ToArray();

            int[] occurence = new int[65535];

            for (int i = 0; i < nums.Length; i++)
            {
                occurence[nums[i]]++;
            }


            var max = occurence.Max();
            for (int i = 0; i < nums.Length; i++)
            {
                if (occurence[nums[i]] == max)
                {
                    Console.WriteLine(nums[i]);
                    break;
                }
            }
        }
    }
}
