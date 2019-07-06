using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingTask.Task1;
using TrainingTask.Task2;
using TrainingTask.Task3;

namespace TrainingTask
{
	class Program
	{
		static void Main(string[] args)
		{
			new FoldersInfo().ShowFolderInfo();
			new FoldersInfo().GetDirectorySize(new DirectoryInfo(@"C:\ForC#\"));

			//new FileCreation().CreateTextFile();

			//new FileReader().FileReading();
		}
	}
}
