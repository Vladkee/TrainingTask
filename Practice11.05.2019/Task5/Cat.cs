using System;
using System.Collections.Generic;
using System.Text;

namespace Practice11._05._2019.Task5
{
	public class Cat : Animal, IPurr
	{
		public override void Bite()
		{
			Console.WriteLine("Кошка {0} кусает", Name);
		}

		public void Purr()
		{
			Console.WriteLine("Кошка {0} мурчит", Name);
		}
	}

}
