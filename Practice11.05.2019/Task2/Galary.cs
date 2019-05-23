using System;
using System.Collections.Generic;
using System.Text;

namespace Practice11._05._2019.Task2
{
	class Galary
	{

		private Plant[] plants;

		private Worker worker;

		public Galary(Plant[] plants, Worker worker)
		{
			this.plants = plants;
			this.worker = worker;
		}

		public void Manage()
		{
			foreach (var item in this.plants)
			{
				Console.WriteLine($"{this.worker.GetType().Name} manage {item.GetType().Name}");
				worker.GrowPlant(item);
			}
		}
	}
}
