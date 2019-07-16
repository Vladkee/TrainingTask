using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingTask.Task2.EmployeeCollection;

namespace TrainingTask.Task3.EmployeeSwapping
{
	public class Management
	{
		public void Execute()
		{
			Employee[] employeesList1 =
				{
				new Employee("Angel", "Vazovski", 20, "M", "Fabrica"),
				new Employee("Egor", "Tusin", 31, "M", "Talisman"),
				new Employee("Elena", "Poleno", 25, "F", "Fabrica"),
				new Employee("Kendrick", "Poleno", 25, "F", "Fabrica")
			};

			Employee[] employeesList2 =
				{
				new Employee("Angel", "Vazovski", 20, "M", "Fabrica"),
				new Employee("John", "Wick", 40, "M", "EASports"),
				new Employee("Elena", "Poleno", 25, "F", "Fabrica"),
				new Employee("Alex", "Huelo", 30, "M", "EASports"),
			};
			//
			// The first part. United arrays into one with duplicates.
			//

			//int lenght = employeesList1.Length + employeesList2.Length; // Need for 1 & 2 cases. 
			//Array.Resize(ref employeesList1, lenght); // Need for 1 & 2 cases.
			//
			// The first case.
			//

			//for (int i = 0; i < employeesList2.Length; i++)
			//{
			//	employeesList1[employeesList2.Length+i] = employeesList2[i];
			//}
			//
			// The second case.
			//

			//Array.Copy(employeesList2, 0, employeesList1, employeesList2.Length, employeesList2.Length);
			//
			// The third case.
			//

			IEnumerable<Employee> queryWithDuplicates = employeesList1.Concat(employeesList2);

			Console.WriteLine($"Copy from array2 to array1 with duplicates (4+4): {Environment.NewLine}");
			foreach (var item in queryWithDuplicates) // or for 1 & 2 case: var item in employeesList2
			{
				Console.WriteLine(item);
			}
			//
			// The second part. United arrays into one without duplicates.
			//

			IEnumerable<Employee> queryWithoutDup = employeesList2.Union(employeesList1);

			Console.WriteLine($"{Environment.NewLine}Copy from array1 to array2 with duplicates: {Environment.NewLine}");
			foreach (var item in queryWithoutDup)
			{
				Console.WriteLine(item);
			}
			//
			// The third part. Display duplicates.
			//

			Console.WriteLine($"{Environment.NewLine}Duplicates in the lists: {Environment.NewLine}");
			IEnumerable<Employee> queryOfDuplicates = employeesList2.Intersect(employeesList1);

			foreach (var item in queryOfDuplicates)
			{
				Console.WriteLine(item);
			}
			//
			// The fouth part. Move array to a list and add an element.
			//

			List<Employee> employeesFromArrayToList = employeesList1.ToList();
			employeesFromArrayToList.Add(new Employee("Oksana", "Ononenko", 24, "F", "Intetics"));

			Console.WriteLine($"{Environment.NewLine}New list with a new element: {Environment.NewLine}");

			foreach (var item in employeesFromArrayToList)
			{
				Console.WriteLine(item);
			}
		}
	}
}
