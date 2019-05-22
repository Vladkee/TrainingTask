using System;
using System.Collections.Generic;
using System.Text;

namespace Practice11._05._2019.Task5
{
	public class Dog : Animal
	{
		public override void Bite()
		{
			Console.WriteLine("Собака {0} кусает", Name);
		}
	}

}
