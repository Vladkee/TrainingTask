using System;
using System.Collections.Generic;
using System.Text;

namespace Practice18._05._2019.Task3
{
	class Greeting
	{
		public void Execute()
		{
			Human[] humans =
				{
			new American("John"),
			new Ukrainian("Петро")
				};

			foreach (var item in humans)
			{
				item.SayHello();
			}
		}
	}
}
