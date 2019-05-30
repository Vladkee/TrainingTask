using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
	class Mammal
	{
		public int Age { get; }

		public int Weight { get; set; }

		public Mammal(int age, int weight)
		{
			this.Age = age;
			this.Weight = weight;
		}

		public virtual void Eat(int foodAmount)
		{
			
		}
	}
}
