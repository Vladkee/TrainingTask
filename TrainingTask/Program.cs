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
            Thread gameLeftBorderThread = new Thread(new ThreadStart(new GameField().GenerateGameBorder));
            gameLeftBorderThread.Start();
            
            Thread trackBorderThread = new Thread(new ThreadStart(new TrackField().GenerateTrackBorder));
            trackBorderThread.Start();

            //new Drawer().Draw();
        }
    }

}
