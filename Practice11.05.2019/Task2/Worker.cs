using System;
using System.Collections.Generic;
using System.Text;

namespace Practice11._05._2019.Task2
{
	class Worker
	{
		public string Name { get; set; }

		public Worker(string name)
		{
			this.Name = name;
		}

		public void WaterPlants(double water)
		{
			if (water > 0 && water <= 10)
			{
				Console.WriteLine($"The {GetType().Name} was watered with {water} L of water. It will grpow on {this.Height++}cm in height.");
			}
			else if (water > 10 && water <= 50)
			{
				Console.WriteLine($"The {GetType().Name} was watered with {water} L of water. It will be {this.Height + 5}cm in height.");
			}
			else if (water > 50)
			{
				Console.WriteLine($"The {GetType().Name} was watered with {water} L of water. It will be {this.Height + 10}cm in height.");
			}
		}

		public void MineralFertilize(double minerals)
		{
			if (minerals > 0 && minerals <= 10)
			{
				Console.WriteLine($"The {GetType().Name} was fertilized with {minerals} g minerals. It will be {Console.ForegroundColor = this.Color++} color.");
				Console.ResetColor();
			}
			else if (minerals > 10 && minerals <= 50)
			{
				Console.WriteLine($"The {GetType().Name} was fertilized with {minerals} g minerals. It will be {Console.ForegroundColor = this.Color++} color.");
				Console.ResetColor();
			}
			else if (minerals > 50)
			{
				Console.WriteLine($"The {GetType().Name} was fertilized with {minerals} g minerals. It will be {Console.ForegroundColor = this.Color++} color.");
				Console.ResetColor();
			}
		}
	}
}
