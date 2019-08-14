using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static TrainingTask.Task1PingPong.GameEventArgs;

namespace TrainingTask.Task1PingPong
{
    public class PingWithDelegate
    {
        public event PingPongDelegate EventPing;

        protected virtual void OnEventPing(GameEventArgs e)
        {
            this.EventPing?.Invoke(this, e);
        }

        public void DoPing()
        {
            Console.WriteLine("Ping...");
            Thread.Sleep(1000);
            this.OnEventPing(new GameEventArgs());
        }

    }
}
