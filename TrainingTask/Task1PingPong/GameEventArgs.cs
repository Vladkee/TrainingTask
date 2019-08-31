using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task1PingPong
{
    public class GameEventArgs : EventArgs
    {
        public delegate void PingPongDelegate(object sender, GameEventArgs e);

        public string Ping { get; }

        public string Pong { get; }

        public GameEventArgs()
        {
            this.Ping = "Ping";
            this.Pong = "Pong";
        }
    }
}
