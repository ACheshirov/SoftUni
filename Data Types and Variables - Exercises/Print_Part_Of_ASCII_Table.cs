using System;

namespace Print_ASCII_Table
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int numFrom = int.Parse (Console.ReadLine());
			int numTo = int.Parse (Console.ReadLine());

			for (int num = numFrom; num <= numTo; num++) {
				char c = Convert.ToChar (num);
				Console.Write (c + " ");
			}
		}
	}
}