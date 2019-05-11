using System;
using System.Collections.Generic;
using System.Text;

namespace Practice11._05._2019.Figures
{
	class Square : Figure
	{
		public double Side { get;}

		public Square(double side, double centerCoordinates)
			:base(centerCoordinates)
		{
			this.Side = side;
			CenterCoordinates = centerCoordinates;
		}

		public void Draw()
		{
			Console.WriteLine($"Square with sides {this.Side}m has {CenterCoordinates} center coordinates");
		}
	}
}
