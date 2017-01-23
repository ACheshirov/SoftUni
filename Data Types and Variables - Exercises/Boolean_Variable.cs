using System;

namespace BooleanVariable
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Boolean isBool = Boolean.Parse (Console.ReadLine());
			if (isBool) {
				Console.WriteLine ("Yes");
			} else {
				Console.WriteLine ("No");
			}
		}
	}
}