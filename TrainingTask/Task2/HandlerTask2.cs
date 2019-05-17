using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2
{
	public class HandlerTask2
	{
		public void Execute()
		{
			MyClassTask2 myClassInstance = new MyClassTask2();
			myClassInstance.SetClassField("Initial class field value.");

			MyStructTask2 myStructureInstance = new MyStructTask2();
			myStructureInstance.SetStructureField("Initial structure field value.");

			this.ClassTaker(myClassInstance);
			this.StructTaker(myStructureInstance);

			Console.WriteLine($"Class field is: {myClassInstance.GetClassField()}");
			Console.WriteLine($"Structure field is: {myStructureInstance.GetStructureField()}");
		}

		private void ClassTaker(MyClassTask2 instance)
		{
			instance.SetClassField("Class has been changed");
		}

		private void StructTaker(MyStructTask2 instance)
		{
			instance.SetStructureField("Structure has been changed");
		}

	}
}
