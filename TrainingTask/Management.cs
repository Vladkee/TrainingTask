using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
	public class Management
	{
		Fridge instance = new Fridge();

		public void Execute()
		{
			Console.WriteLine("What would you like to do?");
			Console.WriteLine("1 - Turn On/Off the fridge");
			Console.WriteLine("2 - Open/Close the main door of the fridge");
			Console.WriteLine("3 - Open/Close the freezer door of the fridge");
			Console.WriteLine("4 - View all states of the fridge");

			var strMainDecision = Console.ReadLine();
			if (!Int32.TryParse(strMainDecision, out int mainDecision))
			{
				throw new Exception("Not a number!");
			}

			if (mainDecision == 1)
			{
				Console.Clear();
				Console.WriteLine("Would you like to Turn On (1) or Turn Off (2)?");
				var strFridgeStateDecision = Console.ReadLine();
				if (!Int32.TryParse(strFridgeStateDecision, out int fridgeStateDecision))
				{
					throw new Exception("Not a number!");
				}

				if (fridgeStateDecision == 1)
				{
					//instance.FridgeEvent += this.OnTurnOn;
					instance.TurnOn();
				}
				else if (fridgeStateDecision == 2)
				{
					//instance.FridgeEvent += this.OnTurnOff;
					instance.TurnOff();
				}
				else
					throw new Exception("Wrong option. Try again!");
			}

			else if (mainDecision == 2)
			{
				Console.Clear();
				Console.WriteLine("Would you like to Open (1) or Close the main door of the fridge (2)?");
				var strMainDoorDecision = Console.ReadLine();
				if (!Int32.TryParse(strMainDoorDecision, out int mainDoorDecision))
				{
					throw new Exception("Not a number!");
				}

				if (mainDoorDecision == 1)
				{
					instance.OpenMainDoor();
				}
				else if (mainDoorDecision == 2)
				{
					instance.CloseMainFridge();
				}
				else
					throw new Exception("Wrong option. Try again!");
			}
			else if (mainDecision == 3)
			{
				Console.Clear();
				Console.WriteLine("Would you like to Open (1) or Close the main door of the fridge (2)?");
				var strFreezerDoorDecision = Console.ReadLine();
				if (!Int32.TryParse(strFreezerDoorDecision, out int freezerDoorDecision))
				{
					throw new Exception("Not a number!");
				}

				if (freezerDoorDecision == 1)
				{
					instance.OpenFreezerDoor();
				}
				else if (freezerDoorDecision == 2)
				{
					instance.CloseFreezerDoor();
				}
				else
					throw new Exception("Wrong option. Try again!");
			}
			else if (mainDecision == 4)
			{
				Console.Clear();
				Console.WriteLine(instance.GetState());
			}
			else
				throw new Exception("Wrong option. Try again!");
		}

		//public void OnTurnOn(object obj, ActionEventArgs args)
		//{
		//	instance.TurnOn();
		//}
		//public void OnTurnOff(object obj, ActionEventArgs args)
		//{
		//	instance.TurnOff();
		//}
	}
}

