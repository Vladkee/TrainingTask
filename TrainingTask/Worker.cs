using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
	class Worker
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public decimal Salary { get; set; }

		public Worker(string name, int age, decimal salary)
		{
			Name = name;
			Age = age;
			Salary = salary;
		}
		
	}
}
