using System;

namespace InstructionSet_broken
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			while (true) {
				string opCode = Console.ReadLine().ToLower();
				if (opCode == "end")
					break;
				
				string[] codeArgs = opCode.Split(' ');

				if (codeArgs [0] == "inc") {
					Console.WriteLine (long.Parse (codeArgs [1]) + 1);
				} else if (codeArgs [0] == "dec") {
					Console.WriteLine (long.Parse (codeArgs [1]) - 1);
				} else if (codeArgs [0] == "add") {
					Console.WriteLine (long.Parse (codeArgs [1]) + long.Parse (codeArgs [2]));
				} else if (codeArgs [0] == "mla") {
					Console.WriteLine (long.Parse (codeArgs [1]) * long.Parse (codeArgs [2]));
				}
			}
		}
	}
}