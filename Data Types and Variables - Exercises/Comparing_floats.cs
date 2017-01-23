using System;

namespace Comparing_floats
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double a = double.Parse (Console.ReadLine());
			double b = double.Parse (Console.ReadLine());

			Console.WriteLine (Math.Abs (a - b) < 0.000001);
		}
	}
}