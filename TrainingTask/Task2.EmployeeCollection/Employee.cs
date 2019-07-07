using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2.EmployeeCollection
{
	public class Employee
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public string Gender { get; set; }
		public string Company { get; set; }

		public Employee(string firstName, string lastName, int age, string gender, string company)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Age = age;
			this.Gender = gender;
			this.Company = company;
		}

		public static List<Employee> GetEmployees()
		{
			return new List<Employee>
			{
				new Employee("John", "Wick", 40, "M", "EASports"),
				new Employee("Elena", "Poleno", 25, "F", "Fabrica"),
				new Employee("Alex", "Huelo", 30, "M", "EASports"),
				new Employee("Pavel", "Kosin", 35, "M", "Tatarkan"),
				new Employee("Egor", "Tusin", 31, "M", "EASports"),
				new Employee("Natali", "Portman", 20, "F", "Talisman"),
				new Employee("Marrie", "Pool", 60, "F", "GrandFact"),
			};
		}
	}
}
