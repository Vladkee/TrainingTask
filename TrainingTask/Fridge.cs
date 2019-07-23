using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrainingTask
{
	public class Fridge
	{
		public event EventDelegate FridgeEvent;
		public Enum State { get; set; } = FridgeSwitchStateEnum.Off;

		public Enum MainDoorState { get; set; } = DoorStateEnum.Closed;

		public Enum FreezerDoorState { get; set; } = DoorStateEnum.Closed;

		protected virtual void OnFridgeEvent(ActionEventArgs args)
		{
			this.FridgeEvent?.Invoke(this, args);
		}

		public void TurnOn()
		{
			this.State = FridgeSwitchStateEnum.On;
			//Console.WriteLine($"Fridge is turned {this.State}..{Environment.NewLine}");

			this.OnFridgeEvent(new ActionEventArgs($"Fridge is Turned {this.State}..{Environment.NewLine}"));
		}

		public void TurnOff()
		{
			this.State = FridgeSwitchStateEnum.Off;
			//Console.WriteLine($"Fridge is turned {this.State}..{Environment.NewLine}");

			this.OnFridgeEvent(new ActionEventArgs($"Fridge is Turned {this.State}..{Environment.NewLine}"));
		}

		public void OpenMainDoor()
		{
			this.MainDoorState = DoorStateEnum.Open;
			//Console.WriteLine($"Main door is {this.MainDoorState}..{Environment.NewLine}");

			this.OnFridgeEvent(new ActionEventArgs($"Main door is {this.MainDoorState}..{Environment.NewLine}"));
		}

		public void CloseMainDoor()
		{
			this.MainDoorState = DoorStateEnum.Closed;
			//Console.WriteLine($"Main door is {this.MainDoorState}..{Environment.NewLine}");

			this.OnFridgeEvent(new ActionEventArgs($"Main door is {this.MainDoorState}..{Environment.NewLine}"));
		}

		public void OpenFreezerDoor()
		{
			this.FreezerDoorState = DoorStateEnum.Open;
			//Console.WriteLine($"Freezer door is open: {this.FreezerDoorState}..{Environment.NewLine}");

			this.OnFridgeEvent(new ActionEventArgs($"Freezer door is {this.FreezerDoorState}..{Environment.NewLine}"));
		}

		public void CloseFreezerDoor()
		{
			this.FreezerDoorState = DoorStateEnum.Closed;
			//Console.WriteLine($"Freezer door is closed: {this.FreezerDoorState}..{Environment.NewLine}");

			this.OnFridgeEvent(new ActionEventArgs($"Freezer door is {this.FreezerDoorState}..{Environment.NewLine}"));
		}

		public string GetState()
		{
			return $"The fridge is turned { this.State} {Environment.NewLine}The main door is { this.MainDoorState} {Environment.NewLine}The freezer door is { this.FreezerDoorState}";
		}
	}
}
