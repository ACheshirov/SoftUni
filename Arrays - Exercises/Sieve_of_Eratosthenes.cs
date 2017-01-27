using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] primes = getPrimaryNumbers(n);
            for (int i = 2; i <= n; i++)
            {
                if (primes[i] > 0)
                    Console.Write(i + " ");
            }
        }

        public static int[] getPrimaryNumbers(int n)
        {
            int[] primes = new int[n+1];
            int i;
            for (i = 2; i <= n; i++)
            {
                primes[i] = i;
            }
            
            i = 2;
            while (i * i <= n)
            {
                if (primes[i] > 0)
                {
                    int k = i;
                    while (k * i <= n)
                    {
                        primes[k * i] = 0;
                        k++;
                    }
                }
                i++;
            }

            return primes;
        }
    }
}
