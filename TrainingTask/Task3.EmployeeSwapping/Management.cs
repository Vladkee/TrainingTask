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
			var employeesList1 = Employee.GetEmployees();
			var employeesList2 = Employee.GetEmployees();
			var employeesList3 = Employee.GetEmployees();
			//
			// The first part of task. Array with duplicates.
			//

			Console.WriteLine("List before:");
			foreach (var item in employeesList1)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine(Environment.NewLine);

			employeesList1.AddRange(employeesList2);
			Console.WriteLine("List after:");
			foreach (var item in employeesList1)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine(Environment.NewLine);
			//
			// The second part of task. Array without duplicates.
			//
			Console.WriteLine("Go to the next part? (y/n)");
			var result = Console.ReadLine();
			if (result == "y")
			{
				Console.Clear();
			}
			else if (result == "n")
			{
				return;
			}

			employeesList2.Add(new Employee("Marrie", "Pool", 30, "F", "Intetics"));
			employeesList2.Add(new Employee("Natali", "Cool", 20, "F", "Intetics"));
			employeesList2.Add(new Employee("Marina", "Fulik", 21, "F", "Intetics"));
			employeesList3.Add(new Employee("John", "Fulik", 22, "M", "Intetics"));
			employeesList3.Add(new Employee("Tomas", "Fulik", 34, "M", "Intetics"));
			employeesList3.Add(new Employee("Jim", "Fulik", 27, "M", "Intetics"));

			Console.WriteLine("List before:");
			foreach (var item in employeesList3)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine(Environment.NewLine);

			employeesList3.Concat(employeesList2);
			Console.WriteLine("List after:");
			foreach (var item in employeesList3)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine(Environment.NewLine);
		}
	}
}
