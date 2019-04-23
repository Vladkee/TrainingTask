using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{

	class Program
	{
		static void Main(string[] args)
		{
			Task000111();
		}

		public static void Task000111()
		{
			Console.WriteLine("Enter amount of elements:");
			var element = Int32.Parse(Console.ReadLine());
			Console.WriteLine($"Enter {element} elements separated by space:");
			var arrayNumbers = Console.ReadLine();

			int[] array = new int[element];
			string[] strArrayNumbers = arrayNumbers.Split(' ');

			Console.WriteLine();

			for (int i = 0; i < array.Length; i++)
			{
				Int32.TryParse(strArrayNumbers[i], out array[i]);
			}
			//foreach (var item in array)
			//{
			//    Console.WriteLine(item);
			string arrayJoin = string.Join(",", array);

			int symbols = 0;
			for (int i = 0; i < array.Length; i++)
			{
				symbols += array[i];
			}

			string bits = "";
			if (array[0] == 0)
			{
				for (int i = 1; i < element; i++)
				{
					if (i % 2 == 0)
						for (int k = 0; k < array[i]; k++)
						{
							bits += 0;
						}
					else
					{
						for (int k = 0; k < array[i]; k++)
						{
							bits += 1;
						}
					}
				}
			}
			else if (array[0] > 0)
			{
				for (int i = 0; i < element; i++)
				{
					if (i % 2 == 0)
						for (int k = 0; k < array[i]; k++)
						{
							bits += 0;
						}
					else
					{
						for (int k = 0; k < array[i]; k++)
						{
							bits += 1;
						}
					}
				}
			}
			Console.WriteLine($"Array {arrayJoin} should looks like {bits}");
		}
	}

	
}
