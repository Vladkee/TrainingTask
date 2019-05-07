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

			Console.WriteLine($"The sum of salary is {sumSalary}");
			Console.WriteLine($"The sum of age is {sumAge}");
		}
	}
}
