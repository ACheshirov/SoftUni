using System;

namespace MaxMethod
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int num1 = int.Parse (Console.ReadLine());
			int num2 = int.Parse (Console.ReadLine());
			int num3 = int.Parse (Console.ReadLine());

			if (GetMax (num1, num2) == num1 && GetMax (num1, num3) == num1)
				Console.WriteLine (num1);
			else if (GetMax (num1, num2) == num2 && GetMax (num2, num3) == num2)
				Console.WriteLine (num2);
			else if (GetMax (num1, num3) == num3 && GetMax (num2, num3) == num3)
				Console.WriteLine (num3);
		}

		public static int GetMax(int a, int b)
		{
			return (a > b) ? a : b;
		}
	}
}