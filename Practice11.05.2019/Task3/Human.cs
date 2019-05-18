using System;
using System.Collections.Generic;
using System.Text;

namespace Practice18._05._2019.Task3
{
	abstract class Human
	{
		public string Name { get; set; }

		public Human(string name)
		{
			this.Name = name;
		}

		public abstract void SayHello();
	}
}
