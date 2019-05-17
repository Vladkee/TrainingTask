using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2
{
	public struct MyStructTask2
	{
		private string change;

		public string GetStructureField()
		{
			return this.change;
		}

		public void SetStructureField(string fieldValue)
		{
			this.change = fieldValue;

		}
	}
}
