using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
	class Task7_SortStringToCamelCase
	{
		public static void Execute()
		{
			string textBefore = GetText();
			string strSplitedText = SplitText(textBefore);
			DisplayText(strSplitedText);
		}

		private static string GetText()
		{
			Console.WriteLine("Enter a text like 'the-stealth-warrior' or 'The_Stealth_Warrior'");
			var textBefore = Console.ReadLine();

			return textBefore;
		}

		private static string SplitText(string textBefore)
		{
			string[] splitedText = textBefore.Split('_', '-');
			string strSplitedText = string.Join("", splitedText);

			return strSplitedText;
		}

		private static void DisplayText(string strSplitedText)
		{
			Console.WriteLine(strSplitedText);
		}

	}
}
