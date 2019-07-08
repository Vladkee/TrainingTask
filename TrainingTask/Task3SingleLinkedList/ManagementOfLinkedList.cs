using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task3SingleLinkedList
{
	public class ManagementOfLinkedList
	{
		private SingleLinkedList<int> singleLinkedList = new SingleLinkedList<int>();
		public void Execute()
		{
			singleLinkedList.Add(1);
			singleLinkedList.Add(2);
			singleLinkedList.Add(3);

			singleLinkedList.Display();
			singleLinkedList.Display2();
		}
	}
}
