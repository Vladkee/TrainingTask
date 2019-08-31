using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrainingTask
{
    public class OtherCar : Drawer
    {
        private TrackField trackField = new TrackField();

        private readonly char carSymbol;

        public OtherCar()
        {
            this.carSymbol = 'x';
        }

        public void CreateCar(int position, int speed)
        {
            for (int i = 1; i < 5; i++)
            {
                Thread.Sleep(speed);

                lock (Drawer.locker)
                {
                    if (i == 1)
                    {
                        GenerateElement(5 + position, i, this.carSymbol);
                    }

                    else if (i == 2)
                    {
                        GenerateElement(5 + position, i, this.carSymbol);

                        GenerateElement(4 + position, i - 1, this.carSymbol);
                        GenerateElement(5 + position, i - 1, this.carSymbol);
                        GenerateElement(6 + position, i - 1, this.carSymbol);
                    }
                    else if (i == 3)
                    {
                        GenerateElement(5 + position, i, this.carSymbol);

                        GenerateElement(4 + position, i - 1, this.carSymbol);
                        GenerateElement(5 + position, i - 1, this.carSymbol);
                        GenerateElement(6 + position, i - 1, this.carSymbol);

                        ClearElement(4 + position, i - 2);
                        ClearElement(6 + position, i - 2);
                        GenerateElement(5 + position, i - 2, this.carSymbol);
                    }
                    else if (i == 4)
                    {
                        GenerateElement(5 + position, i, this.carSymbol);

                        GenerateElement(4 + position, i - 1, this.carSymbol);
                        GenerateElement(5 + position, i - 1, this.carSymbol);
                        GenerateElement(6 + position, i - 1, this.carSymbol);

                        ClearElement(4 + position, i - 2);
                        ClearElement(6 + position, i - 2);
                        GenerateElement(5 + position, i, this.carSymbol);

                        ClearElement(5 + position, i - 3);
                        GenerateElement(4 + position, i - 3, this.carSymbol);
                        GenerateElement(6 + position, i - 3, this.carSymbol);
                    }
                }
            }
        }

        public void RunAnotherCar(int topPosition, int leftPosition)
        {
            lock (Drawer.locker)
            {
                GenerateElement(5 + leftPosition, 5 + topPosition, this.carSymbol);

                GenerateElement(4 + leftPosition, 4 + topPosition, this.carSymbol);
                GenerateElement(5 + leftPosition, 4 + topPosition, this.carSymbol);
                GenerateElement(6 + leftPosition, 4 + topPosition, this.carSymbol);
                GenerateElement(5 + leftPosition, 3 + topPosition, this.carSymbol);

                ClearElement(4 + leftPosition, 3 + topPosition);
                ClearElement(6 + leftPosition, 3 + topPosition);
                GenerateElement(4 + leftPosition, 2 + topPosition, this.carSymbol);
                GenerateElement(6 + leftPosition, 2 + topPosition, this.carSymbol);
                ClearElement(5 + leftPosition, 2 + topPosition);
                ClearElement(4 + leftPosition, 1 + topPosition);
                ClearElement(6 + leftPosition, 1 + topPosition);
            }
        }

        public void DeleteAnotherCar(int leftPosition, int speed)
        {
            for (int i = 1; i < 5; i++)
            {
                Thread.Sleep(speed);

                if (i == 1)
                {
                    ClearElement(4 + leftPosition, trackField.TrackHeight - 4);
                    ClearElement(6 + leftPosition, trackField.TrackHeight - 4);
                    ClearElement(5 + leftPosition, trackField.TrackHeight - 3);
                    GenerateElement(4 + leftPosition, trackField.TrackHeight - 3, this.carSymbol);
                    GenerateElement(6 + leftPosition, trackField.TrackHeight - 3, this.carSymbol);

                    ClearElement(4 + leftPosition, trackField.TrackHeight - 2);
                    ClearElement(6 + leftPosition, trackField.TrackHeight - 2);

                    GenerateElement(4 + leftPosition, trackField.TrackHeight - 1, this.carSymbol);
                    GenerateElement(5 + leftPosition, trackField.TrackHeight - 1, this.carSymbol);
                    GenerateElement(6 + leftPosition, trackField.TrackHeight - 1, this.carSymbol);
                }
                else if (i == 2)
                {
                    ClearElement(4 + leftPosition, trackField.TrackHeight - 3);
                    ClearElement(6 + leftPosition, trackField.TrackHeight - 3);
                    ClearElement(5 + leftPosition, trackField.TrackHeight - 2);
                    GenerateElement(4 + leftPosition, trackField.TrackHeight - 2, this.carSymbol);
                    GenerateElement(6 + leftPosition, trackField.TrackHeight - 2, this.carSymbol);

                    ClearElement(4 + leftPosition, trackField.TrackHeight - 1);
                    ClearElement(6 + leftPosition, trackField.TrackHeight - 1);
                }
                else if (i == 3)
                {
                    ClearElement(4 + leftPosition, trackField.TrackHeight - 2);
                    ClearElement(6 + leftPosition, trackField.TrackHeight - 2);
                    ClearElement(5 + leftPosition, trackField.TrackHeight - 1);
                    GenerateElement(4 + leftPosition, trackField.TrackHeight - 1, this.carSymbol);
                    GenerateElement(6 + leftPosition, trackField.TrackHeight - 1, this.carSymbol);
                }
                else if (i == 4)
                {
                    ClearElement(4 + leftPosition, trackField.TrackHeight - 1);
                    ClearElement(6 + leftPosition, trackField.TrackHeight - 1);
                }
            }
        }
    }
}

