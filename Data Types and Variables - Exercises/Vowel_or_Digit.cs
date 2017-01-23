using System;

namespace HelloWorld
{
	class VowelOrDigit
	{
		public static void Main (string[] args)
		{
			char symbol = char.Parse(Console.ReadLine ().ToLower());

			if (Char.IsDigit(symbol)) {
				Console.WriteLine ("digit");
			} else if (symbol.Equals('a') || symbol.Equals ('e') || symbol.Equals ('i') || symbol.Equals ('o') || symbol.Equals ('u')) {
				Console.WriteLine ("vowel");
			} else {
				Console.WriteLine ("other");
			}
		}
	}
}