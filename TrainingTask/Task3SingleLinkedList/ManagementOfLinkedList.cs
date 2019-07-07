using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task3SingleLinkedList
{
	public class ManagementOfLinkedList
	{
		SingleLinkedList<object> singleLinkedList = new SingleLinkedList<object>();
		public void Execute()
		{
			singleLinkedList.Add(new Node<int>(1));
			singleLinkedList.Add(new Node<int>(2));
			singleLinkedList.Add(new Node<int>(3));

			foreach (var item in singleLinkedList)
			{
				Console.WriteLine(item);
			}
		}
	}
}
