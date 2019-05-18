using Practice18._05._2019;
using Practice18._05._2019.Figures;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice18._05._2019.Task1
{
	class DrawingFigure
	{
		public static void Execute()
		{
			Figure[] figures =
			{
				new Circle(10, 55.45),
				new Square(4.5, 22.15),
				new Triangle(5, 6.6, 7.5, 76.34),
				 };

			foreach (var item in figures)
			{
				item.Draw();
			}
		}
	}
}
