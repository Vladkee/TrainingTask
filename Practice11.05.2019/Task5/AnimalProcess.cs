using System;
using System.Collections.Generic;
using System.Text;

namespace Practice11._05._2019.Task5
{
	class AnimalProcess
	{
		public void AnimalAction()
		{
			Animal[] arrAnimal = new Animal[8];
			arrAnimal[0] = new Dog { Name = "Шарик" };
			arrAnimal[1] = new Cat { Name = "Кусака" };
			arrAnimal[2] = new Cat { Name = "Ленивец" };
			arrAnimal[3] = new Lynx { Name = "Леснушка" };
			arrAnimal[4] = new Dog { Name = "Джек" };
			arrAnimal[5] = new Cat { Name = "Черныш" };
			arrAnimal[6] = new Dog { Name = "Арчи" };
			arrAnimal[7] = new Lynx { Name = "Рыська" };

			foreach (var item in arrAnimal)
			{
				item.Bite();
			}

		}
	}

	public interface IPurr
	{
		void Purr();
	}

}
