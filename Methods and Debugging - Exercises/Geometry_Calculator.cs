using System;

namespace GeometryCalculator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string type = Console.ReadLine ();
			double num1 = double.Parse (Console.ReadLine());

			double numCalc = 0.00;
			if (type == "triangle") {
				double num2 = double.Parse (Console.ReadLine ());
				numCalc = calcTriangle (num1, num2);
			} else if (type == "square")
				numCalc = calcSquare (num1);
			else if (type == "rectangle") {
				double num2 = double.Parse (Console.ReadLine());
				numCalc = calcRect (num1, num2);
			}
			else if (type == "circle")
				numCalc = calcCircle (num1);

			Console.WriteLine ("{0:F2}", numCalc);
		}

		public static double calcTriangle(double a, double b)
		{
			return (a * b) / 2;
		}

		public static double calcSquare(double side)
		{
			return side * side;
		}

		public static double calcRect(double a, double b)
		{
			return a * b;
		}

		public static double calcCircle(double r)
		{
			return Math.PI * (r * r);
		}
	}
}