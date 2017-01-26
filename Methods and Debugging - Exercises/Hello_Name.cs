using System;

namespace HelloName
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			printName (Console.ReadLine());
		}

		public static void printName(string name)
		{
			Console.WriteLine ($"Hello, {name}!");
		}
	}
}