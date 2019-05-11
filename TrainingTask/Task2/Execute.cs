using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2
{
	static class Execute
	{
		public static void GetSalaryAndAge()
		{
			User user1 = new User("Oleg", 20);
			User user2 = new User("Maksim", 25);

			Worker worker1 = new Worker("Kirill", 30, 5555.00m);
			Worker worker2 = new Worker("Tolik", 21, 3000.00m);
			int sumAge = worker1.Age + worker2.Age;
			decimal sumSalary = worker1.Salary + worker2.Salary;

			Student student1 = new Student("Kirill", 30, 5555.00m, 5);
			Student student2 = new Student("Tolik", 21, 3000.00m, 3);

			Driver driver1 = new Driver(2.5, DriverLicenceCategories.A, "Kostya", 25, 10800.00m);
			Driver driver2 = new Driver(5, DriverLicenceCategories.C, "Dima", 30, 12300.00m);

			Console.WriteLine($"The sum of salary is {sumSalary}");
			Console.WriteLine($"The sum of age is {sumAge}");

			Console.WriteLine($"The scholarship of {student1.Name} is {student1.Scholarship}. He's {student1.Course} year student.");
			Console.WriteLine($"The scholarship of {student2.Name} is {student2.Scholarship}. He's {student2.Course} year student.");

			Console.WriteLine($"The driver {driver1.Name} has '{driver1.DriverLicence}' category and {driver1.DriverExperience} years of driver experience.");
			Console.WriteLine($"The driver {driver2.Name} has '{driver2.DriverLicence}' category and {driver2.DriverExperience} years of driver experience.");
		}

	}
}
