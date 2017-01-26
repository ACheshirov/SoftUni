using System;

namespace CubeProperties
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double number = double.Parse (Console.ReadLine());
			string type = Console.ReadLine ();

			double numCalc = 0.00;

			if (type == "face")
				numCalc = calcFace (number);
			else if (type == "space")
				numCalc = calcSpace (number);
			else if (type == "volume")
				numCalc = calcVolume (number);
			else if (type == "area")
				numCalc = calcArea (number);

			Console.WriteLine ("{0:F2}", numCalc);
		}

		public static double calcFace(double number)
		{
			return Math.Sqrt (2 * (number * number));
		}

		public static double calcSpace(double number)
		{
			return Math.Sqrt (3 * (number * number));
		}

		public static double calcVolume(double number)
		{
			return Math.Pow(number, 3);
		}

		public static double calcArea(double number)
		{
			return 6 * (number * number);
		}
	}
}