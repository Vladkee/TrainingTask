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
        public static object locker = new object();

        public virtual void GenerateElement(int left, int top, char symbol)
        {
            lock (Drawer.locker)
            {
                Console.SetCursorPosition(left, top);
                Console.Write(symbol);
            }
        }

        public virtual void ClearElement(int left, int top)
        {
            lock (Drawer.locker)
            {
                Console.SetCursorPosition(left, top);
                Console.Write(' ');
            }
        }
    }
}
