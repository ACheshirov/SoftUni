using System;

namespace ReversedChars
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			char char1 = char.Parse(Console.ReadLine ());
			char char2 = char.Parse(Console.ReadLine ());
			char char3 = char.Parse(Console.ReadLine ());

			Console.WriteLine ("{2}{1}{0}", char1, char2, char3);
		}
	}
}