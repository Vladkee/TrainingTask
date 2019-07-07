using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2.EmployeeCollection
{
	public class CollectionManagement
	{
		public void Execute()
		{
			var employees = Employee.GetEmployees();
			//
			// Last name sorting.
			//

			var sortedEmployeesLastName = employees.OrderBy(employee => employee.LastName);
			Console.WriteLine("Sorted employees with a last name");
			Display(sortedEmployeesLastName);
			Console.WriteLine(Environment.NewLine);
			//
			// Last name sorting.
			//

			var sortedEmployeesAge = employees.Where(employee => employee.Age > 30)
											  .OrderBy(employee => employee.Age);
			Console.WriteLine("Sorted employees with age");
			Display(sortedEmployeesAge);
			Console.WriteLine(Environment.NewLine);
			//
			// Gender sorting.
			//

			var sortedEmployeesMGender = employees.Where(employee => employee.Gender == "M");
			var sortedEmployeesFGender = employees.Where(employee => employee.Gender == "F");
			Console.WriteLine("Sorted employees with gender (M)");
			Display(sortedEmployeesMGender);
			Console.WriteLine("Sorted employees with gender (F)");
			Display(sortedEmployeesFGender);
			Console.WriteLine(Environment.NewLine);
			//
			// Only full name sorting.
			//

			var sortedEmployeesFullName = employees.OrderBy(employee => employee.LastName)
												   .ThenBy(employee => employee.FirstName);
			Console.WriteLine("Sorted employees with a full name");
			Display(sortedEmployeesFullName);
			Console.WriteLine(Environment.NewLine);
			//
			// Women, +20 age, last name with "O" sorting.
			//

			var sortedEmployeesWomenNameWithO = employees.Where(employee => employee.Gender == "F" 
																		 && employee.LastName.StartsWith("O") 
																		 && employee.Age > 20);
			Console.WriteLine("Sorted employees with a last name");
			Display(sortedEmployeesWomenNameWithO);
			Console.WriteLine(Environment.NewLine);
			//
			// Women, +20 age, last name with "O" sorting.
			//

			var sortedEmployeesLastName = employees.OrderBy(employee => employee.LastName);
			Console.WriteLine("Sorted employees with a last name");
			Display(sortedEmployeesLastName);
			Console.WriteLine(Environment.NewLine);
		}

		public void Display(IEnumerable<Employee> employees)
		{
			foreach (var item in employees)
			{
				Console.WriteLine("{0}, {1}, {2}, {3}, {4}", item.LastName, item.FirstName, item.Age, item.Gender, item.Company);
				Console.WriteLine("----------------------------------------");
			}
		}
	}
}
