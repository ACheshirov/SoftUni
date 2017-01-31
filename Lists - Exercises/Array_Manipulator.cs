using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] command;

            while (true)
            {
                command = Console.ReadLine().Split(' ').ToArray();
                if (command[0] == "print") break;

                if (command[0] == "contains")
                {
                    Console.WriteLine(nums.FindIndex(x => x == int.Parse(command[1])));
                }

                if (command[0] == "add")
                {
                    nums.Insert(int.Parse(command[1]), int.Parse(command[2]));
                }

                if (command[0] == "addMany")
                {
                    int startFrom = int.Parse(command[1]);
                    for (int i = 2; i < command.Length; i++)
                    {
                        nums.Insert(i - 2 + startFrom, int.Parse(command[i]));
                    }
                }

                if (command[0] == "sumPairs")
                {
                    int i = 0;
                    while (i + 1 < nums.Count)
                    {
                        nums[i] = nums[i] + nums[i + 1];
                        nums.RemoveAt(i + 1);
                        i++;
                    }
                }

                if (command[0] == "shift")
                {
                    int shiftCount = int.Parse(command[1]);
                    for (int i = 0; i < shiftCount; i++)
                        nums.Add(nums[i]);

                    nums.RemoveRange(0, shiftCount);
                }

                if (command[0] == "remove")
                {
                    nums.RemoveAt(int.Parse(command[1]));
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", nums));
        }
    }
}
