using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
	public class Management
	{
		private Fridge fridge;

		public void Execute()
		{
			this.fridge = new Fridge();
			fridge.FridgeEvent += this.OnEventHandler;

			Console.WriteLine($"{fridge.GetState()}");

			while (true)
			{
				Console.WriteLine(Environment.NewLine);
				Console.WriteLine("What would you like to do?");
				Console.WriteLine("1 - Turn On/Off the fridge.");
				Console.WriteLine("2 - Open/Close the main door of the fridge.");
				Console.WriteLine("3 - Open/Close the freezer door of the fridge.");
				Console.WriteLine("stop - To end process.");

				var strMainDecision = Console.ReadLine();
				if (strMainDecision == "stop")
				{
					return;
				}

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
						fridge.TurnOn();

						Console.WriteLine($"{Environment.NewLine}{fridge.GetState()}");
					}
					else if (fridgeStateDecision == 2)
					{
						//fridge.FridgeEvent += this.OnEventHandler;
						fridge.TurnOff();

						Console.WriteLine($"{Environment.NewLine}{fridge.GetState()}");
					}
					else
						throw new Exception("Wrong option. Try again!");
				}

				else if (mainDecision == 2)
				{
					Console.Clear();
					Console.WriteLine("Would you like to Open (1) or Close the main door of the fridge (2)?");
					var strMainDoorDecision = Console.ReadLine();
					Console.WriteLine(Environment.NewLine);

					if (!Int32.TryParse(strMainDoorDecision, out int mainDoorDecision))
					{
						throw new Exception("Not a number!");
					}

					if (mainDoorDecision == 1)
					{
						//fridge.FridgeEvent += this.OnEventHandler;
						fridge.OpenMainDoor();

						Console.WriteLine($"{Environment.NewLine}{fridge.GetState()}");
					}
					else if (mainDoorDecision == 2)
					{
						//fridge.FridgeEvent += this.OnEventHandler;
						fridge.CloseMainDoor();

						Console.WriteLine($"{Environment.NewLine}{fridge.GetState()}");
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
						//fridge.FridgeEvent += this.OnEventHandler;
						fridge.OpenFreezerDoor();

						Console.WriteLine($"{Environment.NewLine}{fridge.GetState()}");
					}
					else if (freezerDoorDecision == 2)
					{
						//fridge.FridgeEvent += this.OnEventHandler;
						fridge.CloseFreezerDoor();

						Console.WriteLine($"{Environment.NewLine}{fridge.GetState()}");
					}
					else
						throw new Exception("Wrong option. Try again!");
				}
			}
		}

		public void OnEventHandler(object obj, ActionEventArgs args)
		{
			Console.WriteLine(args.Message);
		}
	}
}

