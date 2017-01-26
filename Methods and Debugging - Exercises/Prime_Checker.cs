using System;

namespace PrimeChecker
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			long number = long.Parse (Console.ReadLine());
			Console.WriteLine (isPrime(number));
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
	}
}