using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task1
{
	class Engine : ISwitchable
	{
		public bool state = false;

		public void TurnOn()
		{
			this.state = true;
			Console.WriteLine($"{GetType().Name} is turned on.");
		}

		public void TurnOff()
		{
			this.state = false;
			Console.WriteLine($"{GetType().Name} is turned off.");
		}

		public override string ToString()
		{
			if (this.state)
				return $"{GetType().Name} is on";

			else
				return $"{GetType().Name} is off";
		}
	}
}
