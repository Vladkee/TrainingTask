using System;
using System.Collections.Generic;
using System.Text;

namespace Practice18._05._2019.Task3
{
	class Ukrainian : Human
	{
		public Ukrainian(string name)
			: base(name)
		{
			this.Name = name;
		}

		public override void SayHello()
		{
			Console.WriteLine($"Привiт. Я з Украiни. Мене звати {this.Name}.");
		}
	}
}
