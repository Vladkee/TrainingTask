using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrainingTask
{
    public class GameField : Drawer
    {
        public int GameWindowHeight { get; }

        public int GameWindowWidth { get; }

        private readonly char gameFieldSymbol;

        private TrackField trackField = new TrackField();

        public GameField()
        {
            this.GameWindowHeight = 25;
            this.GameWindowWidth = 60;
            this.gameFieldSymbol = 'X';
            Console.WindowHeight = this.GameWindowHeight;
            Console.WindowWidth = this.GameWindowWidth;
            Console.CursorVisible = false;
        }

        public void GenerateGameBorder()
        {
            for (int i = 0; i < this.GameWindowHeight; i++)
            {
                GenerateElement(0, i, this.gameFieldSymbol);
                GenerateElement(this.GameWindowWidth - 1, i, this.gameFieldSymbol);
                GenerateElement(trackField.TrackWidth + 2, i, this.gameFieldSymbol);
            }

            for (int i = 1; i < this.GameWindowWidth; i++)
            {
                GenerateElement(i, 0, this.gameFieldSymbol);
                GenerateElement(i, this.GameWindowHeight - 1, this.gameFieldSymbol);
            }
        }
    }
}
