using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task3
{
	public class ColorAsker
	{
		public static void Execute()
		{
			string someText = GetText();
			ConsoleColor color = GetColor();
			Print(someText, color);
		}

		private static string GetText()
		{
			Console.WriteLine("Please, enter some text:");
			var someText = Console.ReadLine();

			return someText;
		}

		private static ConsoleColor GetColor()
		{
			Console.WriteLine("Please, enter a number of the color from 0 till 15");
			var colorNumber = Int32.Parse(Console.ReadLine());

			ConsoleColor color = (ConsoleColor)colorNumber;

			return color;
		}
		private static void Print(string someText, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.WriteLine(someText);
			Console.ResetColor();
		}
	}
}
