using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2
{
	class FileCreation
	{
		public void CreateTextFile()
		{
			var path = @"C:\Temp\";
			var file = "Text.txt";
			Console.WriteLine("Please, enter some text to add to the text file.");
			var text = Console.ReadLine();

			if (Directory.Exists(path))
			{
				Console.WriteLine("Folder exists.");
				File.WriteAllText(path + file, text);
				Console.WriteLine("File was created.");
				
			}
			else
			{
				Console.WriteLine("Folder was created.");
				Directory.CreateDirectory(path);
				File.WriteAllText(path + file, text);
				Console.WriteLine("File was created.");
				
			}
		}
	}
}
