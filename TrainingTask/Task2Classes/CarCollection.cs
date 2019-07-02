using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingTask.Task2Classes;

namespace TrainingTask
{
	public class CarCollection<T> : MyList<T> where T : Car
	{
		private MyList<Car> carArray = new MyList<Car>();
		public void Management()
		{
			Console.WriteLine($"Elements: {carArray.ToString()}");
			Console.WriteLine($"Number of elements: {carArray.Count}");
			carArray.Add(new Car("Ford", 2000));
			carArray.Add(new Car("VW", 2013));
			carArray.Add(new Car("Honda", 2017));
			carArray.Add(new Car("Mazda", 2010));
			Console.WriteLine(string.Empty);

			Console.WriteLine($"Elements: {carArray.ToString()}");
			Console.WriteLine($"Number of elements: {carArray.Count}");
			Console.WriteLine(string.Empty);

			//Console.WriteLine(GetInfoAboutCar());
			Console.WriteLine(Environment.NewLine);

			carArray.Clear();
			Console.WriteLine($"Elements: {carArray.ToString()}");
			Console.WriteLine($"Number of elements: {carArray.Count}");
		}

		public override string ToString()
		{
			StringBuilder text = new StringBuilder();
			if (carArray.Count == 0)
			{
				return "No elements";
			}
			else
			{
				for (int i = 0; i < carArray.Count; i++)
				{
					text.AppendLine(carArray[i].ToString());
				}
				return text.ToString();
			}
		}

		//public bool GetInfoAboutCar()
		//{
		//	Console.WriteLine("What the car do you want to find? (enter a car name)");
		//	var carNameToFind = Console.ReadLine();
		//	Console.WriteLine(Environment.NewLine);
		//	var keyCar = new Car(carNameToFind, 2000);
		//	var isExists = carArray.Contains(keyCar);

		//	return isExists;
		//}
	}
}
