using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task1
{
	public class CollectionManagement
	{
		public void Execute()
		{
			StudentCollection instance = new StudentCollection();
			var studentList = instance.GetStudentList();
			
			Console.WriteLine($"Number of elements in list: {studentList.Count}");
			Console.WriteLine($"The list has next elements:");
			for (int i = 0; i < studentList.Count; i++)
			{
				Console.WriteLine(studentList[i].ToString());
			}
			Console.WriteLine(Environment.NewLine);
			//
			// Add element.
			//

			studentList.Add(new Student("Andey", "Fedorchenko", 5, "GIS2012", "GIS"));
			Console.WriteLine($"Number of elements in list: {studentList.Count}");
			Console.WriteLine($"The list has next elements:");
			for (int i = 0; i < studentList.Count; i++)
			{
				Console.WriteLine(studentList[i].ToString());
			}
			Console.WriteLine(Environment.NewLine);
			//
			// Remove element.
			//

			studentList.RemoveAt(1);
			Console.WriteLine($"Number of elements in list: {studentList.Count}");
			Console.WriteLine($"The list has next elements:");
			for (int i = 0; i < studentList.Count; i++)
			{
				Console.WriteLine(studentList[i].ToString());
			}
		}
	}
}
