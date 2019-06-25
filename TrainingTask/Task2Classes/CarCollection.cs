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
		MyList<Car> carArray = new MyList<Car>();
		public void Management()
		{
			Console.WriteLine($"Elements: {carArray.ToString()}");
			Console.WriteLine($"Number of elements: {carArray.Count}");
			carArray.Add(new Car("Ford", 2000));
			carArray.Add(new Car("VW", 2013));
			Console.WriteLine(string.Empty);

			Console.WriteLine($"Elements: {carArray.ToString()}");
			Console.WriteLine($"Number of elements: {carArray.Count}");
			Console.WriteLine(string.Empty);

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
				//Console.WriteLine("Enter an index of element to see info");
				//var strIndex = Console.ReadLine();
				//if (Int32.TryParse(strIndex, out int index))
				//{
				//	if (index > 0 && index <= Count)
				//	{
				//		carArray[index].ToString();
				//	}
				//}
				//else
				//{
				//	throw new Exception("Wrong option");
				//}
			}
		}
	}
}
