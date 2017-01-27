using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myInts = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int half = myInts.Length / 2;
            int part = half / 2;

            int[] sum = new int[half];

            for (int p = 0; p <= 1; p++) {
                for (int i = 0; i < part; i++) {
                    int firstIndex = ((part - 1) + (-i)) + (p * (half + part));
                    int secondIndex = part + i + (p * part);
                    sum[i + (p * part)] = myInts[firstIndex] + myInts[secondIndex];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
