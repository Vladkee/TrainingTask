using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task1
{
	class Execute
	{
		public void Manage()
		{
			Engine eng = new Engine();
			Television tv = new Television();

			Console.WriteLine(eng.ToString());
			Console.WriteLine(tv.ToString());

			Console.WriteLine();
			Console.WriteLine($"Would you like to turn on your devices? ('y' or 'n')");
			var decision = Console.ReadLine();
			Console.WriteLine();

			if(decision == "y")
			{
				eng.TurnOn();
				tv.TurnOn();
			}
			else if (decision == "n")
			{
				eng.TurnOff();
				tv.TurnOff();
			}

			Console.WriteLine();
			Console.WriteLine(eng.ToString());
			Console.WriteLine(tv.ToString());
		}
	}
}
