using System;

namespace Numbers_in_Reversed_Order
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			decimal number = decimal.Parse (Console.ReadLine());
			reverseDigit (number);
		}

		public static void reverseDigit(decimal number)
		{
			string numStr = number.ToString ();
			for (int i = numStr.Length-1; i >= 0; i--) {
				Console.Write (numStr[i]);
			}
		}
	}
}