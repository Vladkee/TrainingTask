using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrainingTask.Task1PingPong
{
    public class Ping
    {
        public event EventHandler EventPing;

        protected virtual void OnNewPing(EventArgs e)
        {
            this.EventPing?.Invoke(this, e);
        }

        public void PrintPing()
        {
            Console.WriteLine("Ping...");
            Thread.Sleep(1000);
            this.OnNewPing(new EventArgs());
        }
    }
}
