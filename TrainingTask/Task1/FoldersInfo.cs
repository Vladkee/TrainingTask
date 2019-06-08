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

			var directotyPath = "C:\\Windows\\System32";
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
			{
			}
		}
		Console.WriteLine($"You have {count} folders in {directotyPath}");
				Console.WriteLine($"Size {size}");
			
		}

}
}
