using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
	public delegate void EventDelegate();
	public class ActionEventArgs : EventArgs
	{
		public event EventDelegate FridgeEvent;

	}
}
