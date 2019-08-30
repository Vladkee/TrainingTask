using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrainingTask
{
    public class TrackField : Drawer
    {
        public int TrackHeight { get; }

        public int TrackWidth { get; }

        private readonly char trackSymbol;

        public TrackField()
        {
            this.trackSymbol = 'I';
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
                        
                        lock (Drawer.locker)
                        {
                            GenerateElement(2, position + i, i);
                            GenerateElement(y, position + i, i);

                            ClearElement(2, position + 1);
                            ClearElement(y, position + 1);
                            ClearElement(2, this.TrackHeight - 1);
                            ClearElement(y, this.TrackHeight - 1);

                            if (position == 2)
                            {
                                GenerateElement(2, position - 1, i);
                                GenerateElement(y, position - 1, i);
                            }
                        }
                    }
                }
            }
        }

        public void GenerateElement(int left, int top, int position)
        {
            lock (Drawer.locker)
            {
                if (position % 4 == 0 && position != 0)
                {
                    Console.SetCursorPosition(left, top);
                    Console.WriteLine(' ');
                }
                else
                {
                    Console.SetCursorPosition(left, top);
                    Console.WriteLine(this.trackSymbol);
                }
            }
        }
    }
}
