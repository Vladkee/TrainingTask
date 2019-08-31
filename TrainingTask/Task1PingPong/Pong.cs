using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrainingTask.Task1PingPong
{
    public class Pong
    {
        public event EventHandler EventPong;

        protected virtual void OnNewPong(EventArgs e)
        {
            this.EventPong?.Invoke(this, e);
        }

        public void PrintPong()
        {
            Console.WriteLine("Pong...");
            Thread.Sleep(1000);
            this.OnNewPong(new EventArgs());
        }
    }
}
