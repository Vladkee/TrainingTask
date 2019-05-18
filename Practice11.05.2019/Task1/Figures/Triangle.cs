using System;
using System.Collections.Generic;
using System.Text;

namespace Practice18._05._2019.Figures
{
	class Triangle : Figure
	{
		public double SideA { get;}

		public double SideB { get;}

		public double SideC { get;}

		public Triangle(double sideA, double sideB, double sideC, double centerCoordinates)
			:base(centerCoordinates)
		{
			this.SideA = sideA;
			this.SideB = sideB;
			this.SideC = sideC;
			CenterCoordinates = centerCoordinates;
		}

		public override void Draw()
		{
			Console.WriteLine($"Triangle with sides A = {this.SideA}m, B = {this.SideB}m, C = {this.SideC}m has {CenterCoordinates} center coordinates");
		}
	}
}
