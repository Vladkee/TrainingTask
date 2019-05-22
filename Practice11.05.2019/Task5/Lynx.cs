using System;
using System.Collections.Generic;
using System.Text;

namespace Practice11._05._2019.Task5
{
	public class Lynx : Animal, IPurr
	{
		public override void Bite()
		{
			Console.WriteLine("Рысь {0} кусает", Name);
		}

		public void Purr()
		{
			Console.WriteLine("Рысь {0} мурчит", Name);
		}
	}

}
