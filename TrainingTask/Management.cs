using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
	public class Management
	{
		public void Execute()
		{
			Console.WriteLine("What would you like to do?");
			Console.WriteLine("1 - Turn On/Off the fridge");
			Console.WriteLine("2 - Open/Close the main door of the fridge");
			Console.WriteLine("3 - Open/Close the freezer door of the fridge");

			var strMainDecision = Console.ReadLine();
			if (!Int32.TryParse(strMainDecision, out int mainDecision))
			{
				throw new Exception("Not a number!");
			}

			if (mainDecision == 1)
			{

			}
			else if (mainDecision == 2)
			{

			}
			else if (mainDecision == 3)
			{

			}
			else
			{
				throw new Exception("Wrong option. Try again!");
			}
		}
	}
}
