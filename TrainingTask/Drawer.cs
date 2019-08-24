using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrainingTask
{
    public class Drawer
    {
        private TrackField trackField = new TrackField();
        private GameField gameField = new GameField();

        public void Draw()
        {
            new TrackField().GenerateTrackBorder();

        }
    }
}
