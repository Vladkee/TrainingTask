using System;
using System.Collections.Generic;
using System.Text;

namespace Practice11._05._2019.Task2
{
	public class GrowingPlants
	{
		public static void Execute()
		{
			Worker[] workers =
			{
				new Worker ("John"),
				new Worker ("Vlad"),
				new Worker ("Dima"),
			};

			var random = new Random();
			foreach (var item in workers)
			{
				var water = random.Next(0, 100);
				item.WaterPlants(water);

				var minerals = random.Next(0, 100);
				item.MineralFertilize(minerals);

				item.OxygenRealease(water, minerals);
			}
		}
	}
}
