using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
	class Program
	{
		static void Main(string[] args)
		{
			//JadenCased();

			//PrinterProgram();

			VowelsProgram();
		}

		public static void JadenCased()
		{
			string nonJadeCase = "How can mirrors be real if our eyes aren't real?";
			Console.WriteLine("Before: ");
			Console.WriteLine(nonJadeCase);
			string[] splitedText = nonJadeCase.Split();
			string JadeCase = "";


			for (int i = 0; i < splitedText.Length; i++)
			{
				string wordWithUpperLetter = splitedText[i].Substring(0, 1).ToUpper() + splitedText[i].Substring(1);
				JadeCase += wordWithUpperLetter + " ";
			}
			Console.WriteLine("After:");
			Console.WriteLine(JadeCase);
		}

		public static void PrinterProgram()
		{
			Console.WriteLine("Enter control text (any letters):");
			var controlLetters = Console.ReadLine().ToLower();
			char[] goodControlString = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'j', 'i', 'j', 'k', 'l', 'm' };
			char[] badControlString = { 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
			int goodCounter = 0;
			int badCounter = 0;

			for (int i = 0; i < controlLetters.Length; i++)
			{
				for (int k = 0, j = 0; k < goodControlString.Length & j < badControlString.Length; k++, j++)
				{
					if (controlLetters[i] == goodControlString[k])
					{
						goodCounter++;
					}
					else if (controlLetters[i] == badControlString[j])
					{
						badCounter++;
					}
				}
			}
			Console.WriteLine($"The control result is {badCounter} 'bad' symbols // {goodCounter} 'good' symbols out of {badCounter + goodCounter}.");
		}

		public static void VowelsProgram()
		{
			Console.WriteLine("Enter any letters:");
			var text = Console.ReadLine().ToLower();
			char[] vowels = { 'a', 'i', 'e', 'o', 'u' };
			int vowelsCounter = 0;

			for (int i = 0; i < text.Length; i++)
			{
				for (int k = 0; k < vowels.Length; k++)
				{
					if (text[i] == vowels[k])
					{
						vowelsCounter++;
					}
				}
			}
			Console.WriteLine();
			Console.WriteLine($"The text '{text}' has {vowelsCounter} vowels.");
		}
	}
}
