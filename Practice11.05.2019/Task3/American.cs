using System;
using System.Collections.Generic;
using System.Text;

namespace Practice18._05._2019.Task3
{
	class American : Human
	{
		public American(string name)
			: base(name)
		{
			this.Name = name;
		}
		public override void SayHello()
		{
			Console.WriteLine($"Hello. I'm from USA. My name is {this.Name},");
		}
	}
}
