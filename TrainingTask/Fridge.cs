using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
	public class Fridge
	{
		public event EventDelegate FridgeEvent;
		public bool State { get; set; }
		
		public bool MainDoorState { get; set; }
		public bool FreezerDoorState { get; set; }

		protected virtual void OnFridgeEvent(ActionEventArgs args)
		{
			this.FridgeEvent?.Invoke(this, args);
		}

		public void TurnOn()
		{
			this.State = true;
			Console.WriteLine($"Fridge is turned on: {this.State}..{Environment.NewLine}");

			this.OnFridgeEvent(new ActionEventArgs());
		}

		public void TurnOff()
		{
			this.State = false;
			Console.WriteLine($"Fridge is turned off: {this.State}..{Environment.NewLine}");

			this.OnFridgeEvent(new ActionEventArgs());
		}

		public void OpenMainDoor()
		{
			this.MainDoorState = true;
			Console.WriteLine($"Main door is open: {this.MainDoorState}..{Environment.NewLine}");

			this.OnFridgeEvent(new ActionEventArgs());
		}

		public void CloseMainFridge()
		{
			this.MainDoorState = false;
			Console.WriteLine($"Main door is closed: {this.MainDoorState}..{Environment.NewLine}");
		}

		public void OpenFreezerDoor()
		{
			this.FreezerDoorState = true;
			Console.WriteLine($"Freezer door is open: {this.FreezerDoorState}..{Environment.NewLine}");

			this.OnFridgeEvent(new ActionEventArgs());
		}

		public void CloseFreezerDoor()
		{
			this.FreezerDoorState = false;
			Console.WriteLine($"Freezer door is closed: {this.FreezerDoorState}..{Environment.NewLine}");

			this.OnFridgeEvent(new ActionEventArgs());
		}

		public string GetState()
		{
			return $"Is turnde on?: { this.State} {Environment.NewLine}Is the main open?: { this.MainDoorState} {Environment.NewLine}Is the freezer door open?: { this.FreezerDoorState}";
		}
	}
}
