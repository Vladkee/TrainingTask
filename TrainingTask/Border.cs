using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrainingTask
{
    public class Border
    {
        private char symbol;

        public Border()
        {
            this.symbol = 'I';
        }

        public void GenerateBorder(int height, int width)
        {
            while (true)
            {
                for (int position = 0; position <= 1; position++)
                {
                    for (int i = 0, y = width; i < height; i++)
                    {
                        Thread.Sleep(1);
                        Console.SetCursorPosition(0, i + position);
                        CreateElement(i);
                        Console.SetCursorPosition(y, i + position);
                        CreateElement(i);
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


    }
}
