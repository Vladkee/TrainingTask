using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task3
{
	public class FileReader
	{
		public void FileReading()
		{
			var filePath = @"C:\ForC#\Text.txt";
			var file = File.ReadAllText(filePath);
			var count = 0;

			for (int i = 0; i < file.Length; i++)
			{
				if (file[i] != ' ' && file[i] != '\n')
				{
					count++;
				}
				else
					continue;
			}
			Console.WriteLine("Elements except spaces " + count);
			Console.WriteLine("Total elements " + file.Length);
		}

	}
}
