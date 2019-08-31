using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static TrainingTask.Task1PingPong.GameEventArgs;

namespace TrainingTask.Task1PingPong
{
    public class PongWithDelegate
    {
        public event PingPongDelegate EventPong;

        protected virtual void OnEventPong(GameEventArgs e)
        {
            this.EventPong?.Invoke(this, e);
        }

        public void DoPong()
        {
            Console.WriteLine("Pong...");
            Thread.Sleep(1000);
            this.OnEventPong(new GameEventArgs());
        }
    }
}
