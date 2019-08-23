using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
    public class Field
    {
        public int Height;

        public int Width;

        public Field()
        {
            this.Height = 20;
            this.Width = 10;
            //Console.WindowHeight = this.Height;
            //Console.WindowWidth = this.Width;
            Console.SetWindowSize(10, 20);
        }
    }
}
