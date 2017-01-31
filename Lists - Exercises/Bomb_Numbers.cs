using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] power = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (true)
            {
                int startFrom = nums.FindIndex(x => x == power[0]);
                if (startFrom == -1) break;

                int startFrom2 = startFrom - power[1];
                int countRemove = power[1] + 1;

                if (startFrom2 < 0)
                {
                    startFrom2 = 0;
                    countRemove = startFrom + 1;
                }

                countRemove += Math.Min(nums.Count - 1 - startFrom, power[1]);

                nums.RemoveRange(startFrom2, countRemove);
            }

            Console.WriteLine(nums.Sum());
        }
    }
}
