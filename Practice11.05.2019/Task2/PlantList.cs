using System;
using System.Collections.Generic;
using System.Text;

namespace Practice11._05._2019.Task2
{
	class PlantList
	{
		public static Plant[] GetPlantList()
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

			return plants;
		}
	}
}
