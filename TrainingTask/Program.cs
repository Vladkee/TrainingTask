using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrainingTask
{
	class Program
	{
		static void Main(string[] args)
		{
            for (int i = 0; i < 65; i++)
            {
                Thread thread = new Thread(new ThreadStart(new Matrix().GenerateRainRow));
                thread.Start();
            }

		}
	}
}
