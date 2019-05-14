using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task1
{
	class Vehicle
	{
		private int wheelCount = 1;
		public ConsoleColor Color { get; set; }
		private int maxSpeed = 1;
		public int PassengerCount { get; set; }

		public int MaxSpeed
		{
			get
			{
				return maxSpeed;
			}
			set
			{
				if (value > 0)
				{
					maxSpeed = value;
				}
			}
		}
		public int WheelCount
		{
			get
			{
				return wheelCount;
			}
			set
			{
				if (value > 0)
				{
					wheelCount = value;
				}
			}
		}

		public Vehicle(int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
		{
			WheelCount = wheelCount;
			Color = color;
			MaxSpeed = maxSpeed;
			PassengerCount = passengerCount;
		}

		public void Move(int meters)
		{
			Console.ForegroundColor = Color;
			Console.WriteLine($"{GetType().Name} has moved {meters} meters");
		}

		public void DisplayAliases()
		{
			Console.WriteLine(string.Format("{0,-10} {1, -12} {2,-13} {3,-18} {4,-20}", "VehicleType", "WheelCount", "Color", "MaxSpeed", "PassengerCount"));
		}
		public void DisplayTable()
		{
			Console.WriteLine(string.Format("{0,-10} {1,-12} {2,-15} {3,-18} {4,-20}", GetType().Name, this.wheelCount, Console.ForegroundColor = this.Color, this.MaxSpeed, this.PassengerCount));
		}
	}
}
