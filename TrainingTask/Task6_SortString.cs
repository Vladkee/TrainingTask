using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
	class Task6_SortString
	{
		public static void Execute()
		{
			string text1 = "xyaabbbccccdefww";
			string text2 = "xxxxyyyyabklmopq";
			string unitedText = UniteText(text1, text2);
			string sortedText = SortString(unitedText);
			string deletedDup = DeleteDuplicates(sortedText);
			DisplayText(deletedDup, unitedText);
		}

		private static string UniteText(string text1, string text2)
		{
			string unitedText = String.Concat(text1, text2);

			return unitedText;
		}
		private static string SortString(string unitedText)
		{
			string sortedText = String.Concat(unitedText.OrderBy(a => a));

			return sortedText;
		}

		private static string DeleteDuplicates(string sortedText)
		{
			string deletedDup = String.Concat(sortedText.OrderBy(a => a).Distinct());

			return deletedDup;
		}

		private static void DisplayText(string deletedDup, string unitedText)
		{
			Console.WriteLine($"The text looks like: {unitedText}");
			Console.WriteLine($"Sorted text looks like: {deletedDup}");
		}
	}
}
