using System;
using System.Collections.Generic;

namespace Primes_in_Given_Range
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int startNum = int.Parse (Console.ReadLine());
			int endNum = int.Parse (Console.ReadLine());

			List<int> primes = FindPrimesInRange (startNum, endNum);
			if (primes.Count > 0) {
				Console.WriteLine (String.Join (", ", primes));
			} else {
				Console.WriteLine("Empty list");
			}
		}

		public static bool isPrime(long number)
		{
			if (number < 2) return false;
			if (number % 2 == 0) return (number == 2);
			int r = (int)Math.Sqrt((double)number);
			for (int i = 3; i <= r; i += 2)
			{
				if (number % i == 0) return false;
			}
			return true;
		}

		public static List<int> FindPrimesInRange(int startNum, int endNum)
		{
			List<int> primes = new List<int> ();
			for (int num = startNum; num <= endNum; num++) {
				if (isPrime (num)) {
					primes.Add (num);
				}
			}

			return primes;
		}
	}
}