using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2
{
	public class MyClassTask2
	{
		private string change;
		public string GetClassField()
		{
			return this.change;
		}

		public void SetClassField(string fieldValue)
		{
			this.change = fieldValue;

		}
	}
}
