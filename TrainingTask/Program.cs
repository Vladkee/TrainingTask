using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingTask.Task1PingPong;
using TrainingTask.Task2Hunter;

namespace TrainingTask
{
	class Program
	{
		static void Main(string[] args)
		{
            //new GameManagerWithDelegate(new PingWithDelegate(), new PongWithDelegate());

            //new GameManager(new Ping(), new Pong());

            new Hunting(new Hunter(), new Rabbit());
        }
	}
}
