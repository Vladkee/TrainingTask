using System;
using System.Collections.Generic;
using System.Text;

namespace Practice11._05._2019.Task2
{
	public class GrowingPlants
	{
		public static void Execute()
		{
			Plant[] plants =
			{
				new Tree (20, Enums.TreesEnum.Birch,200,ConsoleColor.DarkGreen),
				new Tree (10, Enums.TreesEnum.Maple,500,ConsoleColor.DarkCyan),
				new Tree (15, Enums.TreesEnum.Сhestnut, 600, ConsoleColor.DarkMagenta),
				new Flower (5, Enums.FlowersEnum.Pion, 20, ConsoleColor.White),
				new Flower (3, Enums.FlowersEnum.Tulip, 15, ConsoleColor.Red),
				new Flower (4, Enums.FlowersEnum.Rose, 30, ConsoleColor.DarkRed)
			};

			var random = new Random();
			foreach (var item in plants)
			{
				var water = random.Next(0, 100);
				item.WaterConsume(water);

				var minerals = random.Next(0, 100);
				item.MineralConsume(minerals);

				item.OxygenRealease(water, minerals);
			}
		}
	}
}
