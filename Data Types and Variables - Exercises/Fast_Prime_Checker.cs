using System;

namespace FastPrimeChecker
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine());

			for (int num = 2; num <= n; num++) {
				bool isPrime = true;
				for (int div = 2; div <= Math.Sqrt (num); div++) {
					if (num % div == 0) {
						isPrime = false;
						break;
					}
				}

				Console.WriteLine ($"{num} -> {isPrime}");
			}
		}
	}
}