using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myInts = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int k = int.Parse(Console.ReadLine());
            int countNums = myInts.Length;
            int[] sum = new int[countNums];
                       
            for (int i = 1; i <= k; i++)
            {
                for (int n = 0; n < countNums; n++)
                {
                    int index = ((countNums - (i % countNums == 0 ? countNums : i % countNums)) + n) % countNums;
                    sum[n] += myInts[index];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
