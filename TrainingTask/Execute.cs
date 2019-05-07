using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
	static class Execute
	{
		public static void GetSalaryAndAge()
		{
			Worker worker1 = new Worker("Dima", 25, 8300.00m);
			Worker worker2 = new Worker("Oleg", 21, 11100.00m);

			decimal sumSalary = worker1.Salary + worker2.Salary;
			int sumAge = worker1.Age + worker2.Age;

			Console.WriteLine($"The sum of ages is: {sumAge}");
			Console.WriteLine($"The sum of salaries is: {sumSalary}");
		}

	}
}
