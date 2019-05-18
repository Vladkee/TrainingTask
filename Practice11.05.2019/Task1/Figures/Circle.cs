using System;
using System.Collections.Generic;
using System.Text;

namespace Practice18._05._2019.Figures
{
	public class Circle : Figure
	{
		public double CircleRadius { get; }

		public Circle(double circleRadius, double centerCoordinates)
			: base(centerCoordinates)
		{
			this.CircleRadius = circleRadius;
			CenterCoordinates = centerCoordinates;
		}

		public override void Draw()
		{
			Console.WriteLine($"Circle with radius {this.CircleRadius}m has {CenterCoordinates} center coordinates");
		}
	}
}
