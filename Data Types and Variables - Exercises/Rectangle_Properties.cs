using System;

namespace RectangleProperties
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double width = double.Parse (Console.ReadLine());
			double height = double.Parse (Console.ReadLine());

			double perimeter = 2 * (width + height);
			double area = width * height;
			double diagonal = Math.Sqrt (width * width + height * height);

			Console.WriteLine (perimeter);
			Console.WriteLine (area);
			Console.WriteLine (diagonal);
		}
	}
}