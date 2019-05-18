using Practice18._05._2019.Task4;
using Practice18._05._2019.Task4.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice18._05._2019.Task4
{
	class CalculationOption
	{
		public void Execute()
		{
			Operation[] operations =
			{
				new Subtraction(),
				new Sum(),
				new Multiplication(),
				new Divide()
			};

			foreach (var item in operations)
			{
				Console.WriteLine($"{item.GetType().Name} is {item.Calculate(10, 5)}");
			}
		}

	}
}
