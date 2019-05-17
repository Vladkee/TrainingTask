using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task1
{
	class Moto : Vehicle
	{
		public MotoType Type { get; set; }

		public Moto(MotoType type, int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
			: base(wheelCount, color, maxSpeed, passengerCount)
		{
			Type = type;
		}
	}

	enum MotoType
	{
		Adventure,
		Chopper,
		Cruiser,
		Enduro
	}
}
