using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
	public class MammalList
	{
		public Mammal[] GetMammalsList()
		{
			Mammal[] mammals =
		{
			new Arboreal(1, 20),
			new Aquatic(2, 25),
			new Arial(5, 100),
			new Subterranean(5, 11),
			new Terrestrial(2, 2)
		};
			return mammals;
		}
	}
}
