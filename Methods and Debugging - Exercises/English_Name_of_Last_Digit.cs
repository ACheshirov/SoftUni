using System;

namespace English_Name_of_Last_Digit
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			long num = long.Parse (Console.ReadLine());
			Console.WriteLine (getNameOfDigit(num));
		}

		public static string getNameOfDigit(long number)
		{
			string[] digitNames = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
			return digitNames [Math.Abs(number) % 10];
		}
	}
}