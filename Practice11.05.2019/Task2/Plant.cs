using Practice11._05._2019.Task2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice11._05._2019.Task2
{
	class Plant
	{
		public double Height { get; set; }

		public ConsoleColor Color { get; set; }

		public Plant(double height, ConsoleColor color)
		{
			this.Height = height;
			this.Color = color;
		}

		public void WaterConsume(double water)
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

		public void MineralConsume(double minerals)
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

		public void OxygenRealease(double water, double minerals)
		{
			if (water > 0 && minerals > 0 && water <= 10 && minerals <= 10)
			{
				var oxygen = 0;
				Console.WriteLine($"The {GetType().Name} was fertilized with {minerals} g minerals and was watered with {water} L of water. It allocated {oxygen + 5} L of oxygen.");
			}
			else if (water > 10 && minerals > 10 && water <= 50 && minerals <= 50)
			{
				var oxygen = 0;
				Console.WriteLine($"The {GetType().Name} was fertilized with {minerals} g minerals and was watered with {water} L of water. It allocated {oxygen + 10} L of oxygen.");
			}
			else if (water > 50 && minerals > 50)
			{
				var oxygen = 0;
				Console.WriteLine($"The {GetType().Name} was fertilized with {minerals} g minerals and was watered with {water} L of water. It allocated {oxygen + 17} L of oxygen.");
			}
		}
	}
}
