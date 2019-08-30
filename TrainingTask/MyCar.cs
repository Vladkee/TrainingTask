using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
    public class MyCar : Drawer
    {
        private TrackField trackField = new TrackField();

        private readonly char carSymbol;

        public static int MyCarPosition { get; set; }

        public MyCar()
        {
            this.carSymbol = 'x';

            GenerateElement(4, trackField.TrackHeight - 2, this.carSymbol);
            GenerateElement(4, trackField.TrackHeight - 2, this.carSymbol);
            GenerateElement(4, trackField.TrackHeight - 4, this.carSymbol);
            GenerateElement(5, trackField.TrackHeight - 3, this.carSymbol);
            GenerateElement(5, trackField.TrackHeight - 4, this.carSymbol);
            GenerateElement(5, trackField.TrackHeight - 5, this.carSymbol);
            GenerateElement(6, trackField.TrackHeight - 2, this.carSymbol);
            GenerateElement(6, trackField.TrackHeight - 4, this.carSymbol);

            MyCar.MyCarPosition = 1;
        }

        public void MoveLeft()
        {
            GenerateElement(4, trackField.TrackHeight - 2, this.carSymbol);
            GenerateElement(4, trackField.TrackHeight - 4, this.carSymbol);
            GenerateElement(5, trackField.TrackHeight - 3, this.carSymbol);
            GenerateElement(5, trackField.TrackHeight - 4, this.carSymbol);
            GenerateElement(5, trackField.TrackHeight - 5, this.carSymbol);
            GenerateElement(6, trackField.TrackHeight - 2, this.carSymbol);
            GenerateElement(6, trackField.TrackHeight - 4, this.carSymbol);

            ClearElement(trackField.TrackWidth - 4, trackField.TrackHeight - 2);
            ClearElement(trackField.TrackWidth - 4, trackField.TrackHeight - 4);
            ClearElement(trackField.TrackWidth - 3, trackField.TrackHeight - 3);
            ClearElement(trackField.TrackWidth - 3, trackField.TrackHeight - 4);
            ClearElement(trackField.TrackWidth - 3, trackField.TrackHeight - 5);
            ClearElement(trackField.TrackWidth - 2, trackField.TrackHeight - 2);
            ClearElement(trackField.TrackWidth - 2, trackField.TrackHeight - 4);

            MyCar.MyCarPosition = 1;
        }

        public void MoveRight()
        {
            GenerateElement(trackField.TrackWidth - 4, trackField.TrackHeight - 2, this.carSymbol);
            GenerateElement(trackField.TrackWidth - 4, trackField.TrackHeight - 4, this.carSymbol);
            GenerateElement(trackField.TrackWidth - 3, trackField.TrackHeight - 3, this.carSymbol);
            GenerateElement(trackField.TrackWidth - 3, trackField.TrackHeight - 4, this.carSymbol);
            GenerateElement(trackField.TrackWidth - 3, trackField.TrackHeight - 5, this.carSymbol);
            GenerateElement(trackField.TrackWidth - 2, trackField.TrackHeight - 2, this.carSymbol);
            GenerateElement(trackField.TrackWidth - 2, trackField.TrackHeight - 4, this.carSymbol);

            ClearElement(4, trackField.TrackHeight - 2);
            ClearElement(4, trackField.TrackHeight - 4);
            ClearElement(5, trackField.TrackHeight - 3);
            ClearElement(5, trackField.TrackHeight - 4);
            ClearElement(5, trackField.TrackHeight - 5);
            ClearElement(6, trackField.TrackHeight - 2);
            ClearElement(6, trackField.TrackHeight - 4);

            MyCar.MyCarPosition = 2;
        }
    }
}
