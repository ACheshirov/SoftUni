using System;

namespace Substring_broken
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string text = Console.ReadLine ();
			byte count = byte.Parse (Console.ReadLine());

			int temp_i = -1;
			int txtLength = text.Length - 1;

			for (int i = 0; i <= txtLength; i++) {
				if (text [i] == 'p') {
					temp_i = i;
					i += count;
					if (i >= txtLength)
						Console.WriteLine (text.Substring(temp_i));
					else
						Console.WriteLine (text.Substring(temp_i, count+1));
				}
			}

			if (temp_i == -1)
				Console.WriteLine ("no");
		}
	}
}