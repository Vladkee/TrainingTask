using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2Classes
{
	public class Car : ICar
	{
		public string Name { get; set; }
		public int Year { get; set; }

		public Car(string name, int year)
		{
			this.Name = name;
			this.Year = year;
		}

		public override string ToString()
		{
			return this.Name + " " + this.Year;
		}
	}
}
