using System;

namespace DifferentIntegersSize
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string num = Console.ReadLine ();
			string canFit = "";

			try {
				sbyte.Parse (num);
				canFit += "* sbyte" + Environment.NewLine;
			} catch (Exception ex) {
			}

			try {
				byte.Parse (num);
				canFit += "* byte" + Environment.NewLine;
			} catch (Exception ex) {
			}

			try {
				short.Parse (num);
				canFit += "* short" + Environment.NewLine;
			} catch (Exception ex) {
			}

			try {
				ushort.Parse (num);
				canFit += "* ushort" + Environment.NewLine;
			} catch (Exception ex) {
			}

			try {
				int.Parse (num);
				canFit += "* int" + Environment.NewLine;
			} catch (Exception ex) {
			}

			try {
				uint.Parse (num);
				canFit += "* uint" + Environment.NewLine;
			} catch (Exception ex) {
			}

			try {
				long.Parse (num);
				canFit += "* long" + Environment.NewLine;
			} catch (Exception ex) {
			}

			if (canFit.Length > 0) {
				Console.WriteLine ("{0} can fit in:", num);
				Console.Write (canFit);
			} else {
				Console.WriteLine ("{0} can't fit in any type", num);
			}
		}
	}
}