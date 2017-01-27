using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split(' ');
            string[] array2 = Console.ReadLine().Split(' ');

            int maxCount = Math.Max(array1.Length, array2.Length) - 1;
            int minCount = Math.Min(array1.Length, array2.Length) - 1;

            int leftRight = 0;
            int rightLeft = 0;
            bool leftRightMatch = true;
            bool rightLeftMatch = true;

            for (int i = 0; i <= maxCount; i++)
            {
                // Left to right
                if (i <= minCount && array1[i] == array2[i] && leftRightMatch)
                {
                    leftRight++;
                }
                else
                {
                    leftRightMatch = false;
                }

                // Right to left
                int i1 = array1.Length - i - 1;
                int i2 = array2.Length - i - 1;
                if (i1 >= 0 && i2 >= 0 && array1[i1] == array2[i2] && rightLeftMatch)
                {
                    rightLeft++;
                }
                else
                {
                    rightLeftMatch = false;
                }

                if (!leftRightMatch && !rightLeftMatch)
                    break;
            }

            Console.WriteLine(Math.Max(leftRight, rightLeft));
        }
    }
}