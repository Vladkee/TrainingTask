using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingTask.Task1;

namespace TrainingTask
{
	class Program
	{
		static void Main(string[] args)
		{
			Vehicle[] vehicles =
			{
				new Car(4, EngineType.Diesel, GearBoxType.Auto, 4, ConsoleColor.Cyan, 200, 5),
				new Car(2, EngineType.Petrol, GearBoxType.Manual, 4, ConsoleColor.Green, 320, 2),
				new Bicycle(BicycleType.MountainBike, BrakeType.HandBrakes, 2, ConsoleColor.Blue, 60, 1),
				new Bicycle(BicycleType.RoadBike, BrakeType.HandBrakes, 2, ConsoleColor.DarkYellow, 80, 1),
				new Moto(MotoType.Enduro, 2, ConsoleColor.DarkRed, 180, 2),
				new Moto(MotoType.Adventure, 2, ConsoleColor.Magenta, 100, 3)
			};

			for (int y=1, i = 0; i < vehicles.Length; y++, i++)
			{
				if (y == 1)
					vehicles[y].DisplayAliases();

				vehicles[i].DisplayTable();
			}
			
		}
	}
}



