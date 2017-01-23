using System;

namespace TheaThePhotographer
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ulong N = ulong.Parse (Console.ReadLine());
			ulong FT = ulong.Parse (Console.ReadLine());
			byte FF = byte.Parse (Console.ReadLine());
			ulong UT = ulong.Parse (Console.ReadLine());

			ulong totalTime = N * FT;
			totalTime += (ulong)Math.Ceiling(N * (FF / 100.0)) * UT;

			TimeSpan timeSpan = TimeSpan.FromSeconds(totalTime);
			Console.WriteLine ("{0:D1}:{1:D2}:{2:D2}:{3:D2}", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
		}
	}
}