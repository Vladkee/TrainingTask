using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2Hunter
{
    public class HuntingEventArgs : EventArgs
    {
        public int FirstCoordinate;
        public int SecondCoordinate;

        public HuntingEventArgs(int firstCoordinate, int secondCoordinate)
        {
            this.FirstCoordinate = firstCoordinate;
            this.SecondCoordinate = secondCoordinate;
        }
    }
}
