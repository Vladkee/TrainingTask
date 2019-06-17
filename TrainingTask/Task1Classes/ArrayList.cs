using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
	public class ArrayList
	{
		public void Execute()
		{
			MyList<int> array = new MyList<int>();
			Console.WriteLine($"Elements: {array.ToString()}");
			Console.WriteLine($"Number of elements: { array.Count}");
			array.Add(2);
			array.Add(3);
			array.Add(4);
			array.Add(5);
			array.Add(6);
			Console.WriteLine(string.Empty);

			Console.WriteLine($"Elements: {array.ToString()}");
			Console.WriteLine($"Number of elements: { array.Count}");
			Console.WriteLine(string.Empty);

			Console.WriteLine(array.Contains(8));
			Console.WriteLine(array.Contains(6));
			Console.WriteLine(string.Empty);

			array.Clear();
			Console.WriteLine($"Elements: {array.ToString()}");
			Console.WriteLine($"Number of elements: {array.Count}");
		}
	}
}
