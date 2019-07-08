using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task1
{
	public class FoldersInfo
	{
		public DirectoryInfo ShowFolderInfo()
		{
			var directotyPath = @"C:\Windows\System32\";
			DirectoryInfo directInfo = new DirectoryInfo(directotyPath);
			int numberOfFolders = directInfo.GetDirectories().Length;

			double size = 0;
			size = GetDirectorySize(directInfo);

			Console.WriteLine($"You have {numberOfFolders} folders.");
			Console.WriteLine($"Size of all files in this folder is {size}");

			return directInfo;
		}

		public double GetDirectorySize(DirectoryInfo directoryPath)
		{
			double size = 0;
			int counter = 0;

			try
			{
				counter = directoryPath.GetDirectories().Length;

				foreach (FileInfo file in directoryPath.GetFiles())
				{
					size += file.Length;
				}

				if (counter == 0)
				{
					return size;
				}

				foreach (var item in directoryPath.GetDirectories())
				{
					size += GetDirectorySize(item);
				}
			}

			catch (Exception error)
			{
				Console.WriteLine(error.Message);
			}
			return size;
		}
	}
}
