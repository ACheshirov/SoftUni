using System;

namespace ExchangeVariableValues
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			byte a = 5;
			byte b = 10;

			byte temb_b = b;

			Console.WriteLine ("Before:");
			Console.WriteLine ("a = " + a);
			Console.WriteLine ("b = " + b);

			b = a;
			a = temb_b;

			Console.WriteLine ("After:");
			Console.WriteLine ("a = " + a);
			Console.WriteLine ("b = " + b);
		}
	}
}