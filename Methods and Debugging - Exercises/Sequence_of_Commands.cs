using System;
using System.Linq;

namespace SequenceOfCommands_broken
{
	class MainClass
	{
		private const char ArgumentsDelimiter = ' ';
		private static long[] array;

		public static void Main (string[] ar)
		{
			Console.ReadLine();

			array = Console.ReadLine()
				.Split(ArgumentsDelimiter)
				.Select(long.Parse)
				.ToArray();

			while (true)
			{
				string command = Console.ReadLine();
				if (command == "stop")
					break;
				
				string[] stringParams = command.Trim().Split(ArgumentsDelimiter);
				int[] args = new int[2];

				if (stringParams[0].Equals("add") ||
					stringParams[0].Equals("subtract") ||
					stringParams[0].Equals("multiply"))
				{
					
					args[0] = int.Parse(stringParams[1]);
					args[1] = int.Parse(stringParams[2]);
				}

				PerformAction(stringParams[0], args);

				PrintArray();
			}
		}

		static void PerformAction(string action, int[] args)
		{
			int pos = args[0] - 1;
			int value = args[1];

			switch (action)
			{
			case "multiply":
				array[pos] *= value;
				break;
			case "add":
				array[pos] += value;
				break;
			case "subtract":
				array[pos] -= value;
				break;
			case "lshift":
				ArrayShiftLeft();
				break;
			case "rshift":
				ArrayShiftRight();
				break;
			}
		}

		private static void ArrayShiftRight()
		{
			long lastEl = array [array.Length - 1];
			for (int i = array.Length - 1; i >= 1; i--)
			{
				array[i] = array[i - 1];
			}
			array [0] = lastEl;
		}

		private static void ArrayShiftLeft()
		{
			long firstEl = array [0];
			for (int i = 0; i < array.Length - 1; i++)
			{
				array[i] = array[i + 1];
			}
			array [array.Length - 1] = firstEl;
		}

		private static void PrintArray()
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i] + " ");
			}
			Console.WriteLine ();
		}
	}
}