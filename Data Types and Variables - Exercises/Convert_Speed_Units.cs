using System;

namespace ConvertSpeedUnits
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int distance = int.Parse (Console.ReadLine());
			int hours = int.Parse (Console.ReadLine());
			int minutes = int.Parse (Console.ReadLine());
			int seconds = int.Parse (Console.ReadLine());

			float hourTime = hours + minutes / 60.0f + seconds / 3600.0f;

			float kmph = (distance / 1000.0f) / hourTime;
			float mps = kmph / 3.6f;
			float mph = (distance / 1609.0f) / hourTime;

			Console.WriteLine ("{0}", mps);
			Console.WriteLine ("{0}", kmph);
			Console.WriteLine ("{0}", mph);
		}
	}
}