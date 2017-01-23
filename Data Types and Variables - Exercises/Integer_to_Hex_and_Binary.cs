using System;

namespace Integer2Hex_Binary
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int decValue = int.Parse(Console.ReadLine());

			string hexValue = decValue.ToString("X");
			string binaryValue = Convert.ToString(decValue, 2);

			Console.WriteLine (hexValue);
			Console.WriteLine (binaryValue);
		}
	}
}