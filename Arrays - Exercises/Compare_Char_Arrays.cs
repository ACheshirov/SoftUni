using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] chars2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            if (compareChars(chars1, chars2))
            {
                Console.WriteLine(string.Join("", chars1));
                Console.WriteLine(string.Join("", chars2));
            }
            else
            {
                Console.WriteLine(string.Join("", chars2));
                Console.WriteLine(string.Join("", chars1));
            }
        }

        public static bool compareChars(char[] a, char[] b)
        {
            int minVal = Math.Min(a.Length, b.Length);
            for (int i = 0; i < minVal; i++)
            {
                if ((int)a[i] < (int)b[i])
                {
                    return true;
                }
                else if ((int)a[i] > (int)b[i])
                {
                    return false;
                }
            }

            return a.Length < b.Length;
        }
    }
}
