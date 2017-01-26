using System;

namespace LongerLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double line1_x1 = double.Parse (Console.ReadLine());
			double line1_y1 = double.Parse (Console.ReadLine());
			double line1_x2 = double.Parse (Console.ReadLine());
			double line1_y2 = double.Parse (Console.ReadLine());

			double line2_x1 = double.Parse (Console.ReadLine());
			double line2_y1 = double.Parse (Console.ReadLine());
			double line2_x2 = double.Parse (Console.ReadLine());
			double line2_y2 = double.Parse (Console.ReadLine());

			double line_x1, line_y1, line_x2, line_y2;
			if (calcDistance (line1_x1, line1_y1, line1_x2, line1_y2) >= calcDistance (line2_x1, line2_y1, line2_x2, line2_y2)) {
				line_x1 = line1_x1;
				line_y1 = line1_y1;
				line_x2 = line1_x2;
				line_y2 = line1_y2;
			} else {
				line_x1 = line2_x1;
				line_y1 = line2_y1;
				line_x2 = line2_x2;
				line_y2 = line2_y2;
			}

			if (calcDistance (line_x1, line_y1, 0, 0) <= calcDistance (line_x2, line_y2, 0, 0)) {
				Console.WriteLine ($"({line_x1}, {line_y1})({line_x2}, {line_y2})");
			} else {
				Console.WriteLine ($"({line_x2}, {line_y2})({line_x1}, {line_y1})");
			}
		}

		public static double calcDistance(double x1, double y1, double x2, double y2)
		{
			return Math.Sqrt (Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
		}
	}
}