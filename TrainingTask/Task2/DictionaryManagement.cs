using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingTask.Task1;

namespace TrainingTask.Task2
{
	public class DictionaryManagement
	{
		public void DictionaryExecute()
		{
			StudentDictionary instance = new StudentDictionary();
			var studentDict = instance.GetStudentDictionary();
			studentDict.Add("Dima Bulgakov", new Student("Dima", "Bulgakov", 3, "B23", "Mathematics"));

			Console.WriteLine($"Number of elements in list: {studentDict.Count}");

			foreach (var item in studentDict)
			{
				Console.WriteLine(item.Value);
			}
			Console.WriteLine(Environment.NewLine);

			Console.WriteLine("Who are you looking for? (enter a name and a last name");
			var studentToFind = Console.ReadLine();
			Console.WriteLine(Environment.NewLine);

			if (studentDict.TryGetValue(studentToFind, out Student keyStudent))
			{
				Console.WriteLine($"Yes. This student is found. Here is some info:");
				Console.WriteLine(keyStudent);
			}
			else
			{
				Console.WriteLine($"No. This student isn't found.");
			}
		}
	}
}
