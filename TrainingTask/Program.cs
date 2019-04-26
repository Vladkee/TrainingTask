﻿using System;
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
			JadenCased();
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
	}
}
