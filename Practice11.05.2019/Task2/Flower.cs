using Practice11._05._2019.Task2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice11._05._2019.Task2
{
	class Flower : Plant
	{
		public int AmountOfFlowers { get; set; }
		public FlowersEnum Kind { get; set; }

		public Flower(int amountOfFlowers, FlowersEnum kind, double height, ConsoleColor color)
			: base(height, color)
		{
			this.AmountOfFlowers = amountOfFlowers;
			this.Kind = kind;
			Height = height;
			Color = color;
		}
	}
}
