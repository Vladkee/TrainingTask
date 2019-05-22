using Practice11._05._2019.Task2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice11._05._2019.Task2
{
	class Tree : Plant
	{
		public int AmountOfFruits { get; set; }
		public TreesEnum Kind { get; set; }
		public Tree(int amountOfFruits, TreesEnum kind, double height, ConsoleColor color)
			: base(height, color)
		{
			this.AmountOfFruits = amountOfFruits;
			this.Kind = kind;
			Height = height;
			Color = color;
		}
	}
}
