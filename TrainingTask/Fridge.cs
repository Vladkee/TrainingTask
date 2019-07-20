using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
	public class Fridge
	{
		public bool State { get; set; }
		public bool MainDoorState { get; set; }
		public bool FreezerDoorState { get; set; }

		public void TurnOn()
		{
			this.State = true;
		}

		public void TurnOff()
		{
			this.State = false;
		}

		public void OpenMainDoor()
		{
			this.MainDoorState = true;
		}

		public void CloseMainFridge()
		{
			this.MainDoorState = false;
		}

		public void OpenFreezerDoor()
		{
			this.FreezerDoorState = true;
		}

		public void CloseFreezerDoor()
		{
			this.FreezerDoorState = false;
		}
	}
}
