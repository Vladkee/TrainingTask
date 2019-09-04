using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
	public class Mammal
	{
		public int Age { get; }

		public int Weight { get; set; }

		public Mammal(int age, int weight)
		{
			this.Age = age;
			this.Weight = weight;
		}

		public void Eat(int foodAmount)
        {
            Console.WriteLine($"{GetType().Name}'s weight before is {this.Weight}.");

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
