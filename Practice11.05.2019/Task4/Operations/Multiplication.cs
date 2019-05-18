using System;
using System.Collections.Generic;
using System.Text;

namespace Practice18._05._2019.Task4.Operations
{
	class Multiplication : Operation
	{
		public override double Calculate(double firstNumber, double secondNumber)
		{
			return firstNumber * secondNumber;
		}
	}
}
