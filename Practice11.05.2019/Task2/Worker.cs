using System;
using System.Collections.Generic;
using System.Text;

namespace Practice11._05._2019.Task2
{
	class Worker
	{
		public void GrowPlant(Plant plant)
		{
			var random = new Random();

			var water = random.Next(0, 100);
			var minerals = random.Next(0, 100);

			plant.WaterConsume(water);

			plant.MineralConsume(minerals);

			plant.OxygenRealease(water, minerals);

		}
	}
}
