using System;
using System.Numerics;

namespace Factorial
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ushort num = ushort.Parse (Console.ReadLine());

			Console.WriteLine (getFactorial(num));
		}

		public static BigInteger getFactorial(ushort num)
		{
			BigInteger f = 1;
			for (ushort i = num; i >= 2; i--) {
				f *= i;
			}

			return f;
		}
	}
}