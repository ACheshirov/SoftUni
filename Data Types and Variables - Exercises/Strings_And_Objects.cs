using System;

namespace StringsAndObjects
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string str1 = "Hello";
			string str2 = "World";

			object str = str1 + " " + str2;
			string sentence = (string)str;
          	
			Console.WriteLine (sentence);
		}
	}
}