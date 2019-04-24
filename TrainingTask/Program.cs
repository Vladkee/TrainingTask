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
			//Task000111();

			Products();
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

		public static void Products()
		{
			string[] products = new string[] { "Груши", "Яблоки", "Огурцы", "Помидоры", "Укроп", "Петрушка", "Курица", "Сыр", "Масло", "Молоко" };
			decimal[] prices = new decimal[] { 40.50m, 31.20m, 21.80m, 35.00m, 150.00m, 145.00m, 200.00m, 400.00m, 81.40m, 81.40m };
			decimal sumToBuy = 0.00m;

			while (true)
			{
				Console.WriteLine("What you want to buy? If you would like to stop the process press '0'.");
				Console.Write("Please, enter the code of a product 1-10: ");
				string strCodeOfProduct = Console.ReadLine();
				Console.WriteLine();

				bool isStopNumber = Int32.TryParse(strCodeOfProduct, out int codeOfProduct);
				if (codeOfProduct == 0)
				{
					Console.WriteLine($"You should pay {sumToBuy} gryvnias for the products.");
					Console.WriteLine();
					break;
				}
	 			else if (!isStopNumber)
				{
					Console.WriteLine("You've entered not a number. Try again!");
					break;
				}

				Console.WriteLine("How many you want to buy?");
				Console.Write("Please, enter amount of the product: ");
				var amountOfProduct = Decimal.Parse(Console.ReadLine());
				Console.WriteLine();

				sumToBuy += prices[codeOfProduct-1] * amountOfProduct;
			}
		}
	}
}
