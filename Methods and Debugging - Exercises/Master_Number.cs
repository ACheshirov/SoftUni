using System;

namespace MasterNumber
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int num = int.Parse (Console.ReadLine());

			for (int i = 1; i <= num; i++) {
				if (isMaster(i))
					Console.WriteLine (i);
			}
		}

		public static bool isMaster(int number)
		{
			return (SumOfDigits (number) && ContainsEvenDigit (number) && IsPalindrome(number));
		}

		public static bool SumOfDigits(int number)
		{
			int sum = 0;

			while (number != 0) {
				sum += number % 10;
				number /= 10;
			}

			return sum % 7 == 0;
		}

		public static bool ContainsEvenDigit(int number)
		{
			while (number != 0) {
				if ((number % 10) % 2 == 0)
					return true;
				
				number /= 10;
			}

			return false;
		}

		public static bool IsPalindrome(int number)
		{
			if (number < 10)
				return true;

			string sNum = number.ToString ();

			for (int i = 0; i<sNum.Length; i++) 
				if (sNum[i] != sNum[sNum.Length-1-i]) return false;

			return true;
		}
	}
}