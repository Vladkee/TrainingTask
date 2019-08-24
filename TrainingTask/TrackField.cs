using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrainingTask
{
    public class TrackField
    {
        public int TrackHeight;

        public int TrackWidth;

        public char symbol;

        public static object locker = new object();

        public TrackField()
        {
            this.symbol = 'I';
            this.TrackHeight = 24;
            this.TrackWidth = 20;
        }

        public void GenerateTrackBorder()
        {
            while (true)
            {
                for (int position = 0; position <= 2; position++)
                {
                    Thread.Sleep(80);

                    for (int i = 2, y = this.TrackWidth; i < this.TrackHeight - 2; i++)
                    {
                        lock (locker)
                        {
                            Console.SetCursorPosition(1, i + position);
                            CreateElement(i);
                            Console.SetCursorPosition(y, i + position);
                            CreateElement(i);

                            ClearElement(1, position+1);
                            ClearElement(y, position+1);
                            ClearElement(1, this.TrackHeight-1);
                            ClearElement(y, this.TrackHeight-1);

                            if (position == 2)
                            {
                                Console.SetCursorPosition(1, position - 1);
                                CreateElement(i);
                                Console.SetCursorPosition(y, position - 1);
                                CreateElement(i);
                            }
                        }
                    }
                }
            }
        }

        public void CreateElement(int position)
        {

            if (position % 4 == 0 && position != 0)
            {
                Console.WriteLine(' ');
            }
            else
            {
                Console.WriteLine(this.symbol);
            }
        }

        public void ClearElement(int positionLeft, int positionTop)
        {
            Console.SetCursorPosition(positionLeft, positionTop);
            Console.WriteLine(' ');
        }
    }
}
