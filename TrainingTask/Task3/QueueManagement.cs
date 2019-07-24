using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrainingTask.Task3
{
	public class QueueManagement
	{
		public void QueueExecute()
		{
			TaskList instance = new TaskList();
			var listOfTasks = instance.GetTaskList();

			Queue<Task> queueOfTasks = new Queue<Task>();

			Console.WriteLine("List of tasks:");
			for (int i = 0; i < listOfTasks.Count; i++)
			{
				queueOfTasks.Enqueue(listOfTasks.ElementAt(i));
			}

			foreach (var item in queueOfTasks)
			{
				Console.WriteLine(item);
			}

			for (int i = 0; i < queueOfTasks.Count;)
			{
				Console.WriteLine($"{Environment.NewLine}{queueOfTasks.Peek()}");
				Console.WriteLine("...");

				Thread.Sleep(1000);

				Console.WriteLine($"{queueOfTasks.Peek()}...DONE{Environment.NewLine}");
				queueOfTasks.Dequeue();
			}
			Console.WriteLine("All tasks have been done.");
		}
	}
}
