using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task1
{
	class Worker
	{
		private string name;
		private int age;
		private decimal salary;

		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
		public int Age
		{
			get
			{
				return age;
			}
			set
			{
				if (value > 1 && value < 100)
				{
					age = value;
				}
				else
				{
					throw new ArgumentException($"Incorrect age! {name}");
				}
			}
		}
		public decimal Salary
		{
			get
			{
				return salary;
			}
			set
			{
				salary = value;
			}
		}

		public Worker(string name, int age, decimal salary)
		{
			Name = name;
			Age = age;
			Salary = salary;
		}

	}
}
