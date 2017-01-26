using System;

namespace CenterPoint
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double x1 = double.Parse (Console.ReadLine());
			double y1 = double.Parse (Console.ReadLine());

			double x2 = double.Parse (Console.ReadLine());
			double y2 = double.Parse (Console.ReadLine());

			double dist1 = calcDistance(x1, y1);
			double dist2 = calcDistance(x2, y2);

			if (dist1 <= dist2) {
				Console.WriteLine ($"({x1}, {y1})");
			} else {
				Console.WriteLine ($"({x2}, {y2})");
			}
		}

		public static double calcDistance(double x, double y)
		{
			return Math.Sqrt (x * x + y * y);
		}
	}
}