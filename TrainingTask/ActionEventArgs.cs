using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
	public delegate void EventDelegate(object obj, ActionEventArgs args);
	public class ActionEventArgs : EventArgs
	{	}
}
