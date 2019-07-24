using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task3
{
	public class TaskList
	{
		private List<Task> listOfTasks = new List<Task>()
		{
			new Task(1, "Count money"),
			new Task(2, "Water flowers"),
			new Task(3, "Make coffee")
		};

		public List<Task> GetTaskList()
		{
			return listOfTasks;
		}
	}
}
