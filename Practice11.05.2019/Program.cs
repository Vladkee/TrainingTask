using Practice11._05._2019.Figures;
using System;

namespace Practice11._05._2019
{
	class Program
	{
		static void Main(string[] args)
		{
			Figure[] figures =
				{
				new Circle(10, 55.45),
				new Circle(4.6, 33.11),
				new Square(4.5, 22.15),
				new Square(12, 34.89),
				new Triangle(5, 6.6, 7.5, 76.34),
				new Triangle(4.2, 8.7, 4, 35.21)
				 };

			foreach (var item in figures)
			{
				if(item is Circle circle)
				{
					circle.Draw();
				}
				else if (item is Triangle triangle)
				{
					triangle.Draw();
				}
				else if (item is Square square)
				{
					square.Draw();
				}
			}
		}
	}
}
