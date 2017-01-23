using System;

namespace VariableinHexFormat
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int hex = Convert.ToInt32 (Console.ReadLine (), 16);
			Console.WriteLine (hex);
		}
	}
}