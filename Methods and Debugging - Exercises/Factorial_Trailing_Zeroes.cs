using System;
using System.Numerics;

namespace FactorialTrailingZeroes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ushort num = ushort.Parse (Console.ReadLine());
			BigInteger factorial = getFactorial (num);

			Console.WriteLine (calcTrailingZeroes(factorial));
		}

		public static BigInteger getFactorial(ushort num)
		{
			BigInteger f = 1;
			for (ushort i = num; i >= 2; i--) {
				f *= i;
			}

			return f;
		}

		public static int calcTrailingZeroes(BigInteger number)
		{
			int total = 0;
			while (number != 0) {
				if (number % 10 == 0) {
					total++;
				} else {
					break;
				}
				number /= 10;
			}

			return total;
		}
	}
}