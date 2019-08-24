using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrainingTask
{
    public class GameField
    {
        public int GameWindowHeight;

        public int GameWindowWidth;

        private char symbol;

        public static object locker = new object();

        public GameField()
        {
            this.GameWindowHeight = 25;
            this.GameWindowWidth = 60;
            this.symbol = 'x';
            Console.WindowHeight = this.GameWindowHeight;
            Console.WindowWidth = this.GameWindowWidth;
            Console.CursorVisible = false;
        }

        public void GenerateGameBorder()
        {
            for (int i = 0; i < this.GameWindowHeight; i++)
            {
                lock (locker)
                {
                    GenerateElement(0, i);
                    GenerateElement(this.GameWindowWidth - 1, i);
                }
            }

            for (int i = 1; i < this.GameWindowWidth; i++)
            {
                GenerateElement(i, 0);
                GenerateElement(i, this.GameWindowHeight-1);
            }
        }

        public void GenerateElement(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(this.symbol);

        }
    }
}
