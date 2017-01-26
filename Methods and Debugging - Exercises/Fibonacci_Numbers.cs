using System;

namespace FibonacciNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine());
			Console.WriteLine (Fib(n));
		}

		public static int Fib(int n)
		{
			int a = 0;
			int b = 1;

			for (int i = 0; i <= n; i++)
			{
				int temp = a;
				a = b;
				b = temp + b;
			}

			return a;
		}
	}
}