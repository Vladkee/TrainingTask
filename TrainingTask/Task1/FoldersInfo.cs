using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task1
{
	class FoldersInfo
	{
		public void ShowFolderInfo()
		{
			var directotyPath = Path.GetFullPath("C:\\ForC#\\");
			//var currentFolder = Path.GetDirectoryName(directotyPath);
			//var currentFolder = new DirectoryInfo(directotyPath).Name;
			//Console.WriteLine(currentFolder);
			//string[] folderPath = currentFolder.Split('\\');
			//Console.WriteLine(folderPath[folderPath.Length-1]);

			DirectoryInfo directInfo = new DirectoryInfo(directotyPath);
			var size = 0;
			var count = 0;
			
			foreach (var item in Directory.GetDirectories(directotyPath))
			{
				try
				{
					count = directInfo.GetDirectories().Count();

					foreach (var file in Directory.GetFiles(item))
					{
						size += file.Length;
					}
				}

				catch (Exception)
				{ }
			}
			Console.WriteLine($"You have {count} folders in {directotyPath}");
			Console.WriteLine($"Size: {size} Kb");

			//while (isFolderExists)
			//{
			//	ShowFolderInfo();
			//}
		}
	}
}
