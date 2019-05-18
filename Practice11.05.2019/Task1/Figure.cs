using System;
using System.Collections.Generic;
using System.Text;

namespace Practice18._05._2019
{
	public abstract class Figure
	{
		public double CenterCoordinates { get; set; }

		public Figure(double centerCoordinates)
		{
			this.CenterCoordinates = centerCoordinates;
		}

		public abstract void Draw();

	}
}
