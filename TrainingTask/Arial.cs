using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
	class Arial : Mammal
	{
		public Arial(int age, int weight) : base(age, weight)
		{
			this.Weight = weight;
		}
		public override void Eat(int foodAmount)
		{
			Console.WriteLine($"{GetType().Name}'s weight before is {this.Weight} kg.");

			if (this.Age <= 1)
			{
				Console.WriteLine($"{GetType().Name} drinks milk.");
			}
			else
			{
				Console.WriteLine($"{GetType().Name} eats some food.");
			}

			this.Weight += foodAmount / 5;

			Console.WriteLine($"The {GetType().Name}'s weight is {this.Weight} kg.");
		}
	}
}
