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
            GameLogic gameLogic = new GameLogic();

            Thread gameFieldThread = new Thread(new ThreadStart(new GameLogic().RunGame));
            gameFieldThread.Start();

            //Thread.Sleep(4000);

            Thread trackBorderThread = new Thread(new ThreadStart(new TrackField().GenerateTrackBorder));
            trackBorderThread.Start();

            Thread firstOtherCarThread = new Thread(new ThreadStart(new GameLogic().SendOtherCar));

            Thread secondOtherCarThread = new Thread(new ThreadStart(new GameLogic().SendOtherCar));

            for (int i = 0; i <= 1; i++)
            {
                if (i == 0)
                {
                    firstOtherCarThread.Start();
                }
                else
                {
                    Thread.Sleep(1550);
                    secondOtherCarThread.Start();
                }
            }
        }
    }
}
