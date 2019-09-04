using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
	public class Feeder
	{
		public void Feed(Mammal[] mammals)
		{
			foreach (var item in mammals)
			{
				Random random = new Random();
				item.Eat(random.Next(1,100));
				Console.WriteLine(string.Empty);
			}
		}
	}
}
