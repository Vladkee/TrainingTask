using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task1PingPong
{
    public class GameManagerWithDelegate
    {
        public PingWithDelegate Ping { get; set; }

        public PongWithDelegate Pong { get; set; }

        public GameManagerWithDelegate(PingWithDelegate ping, PongWithDelegate pong)
        {
            this.Ping = ping;
            this.Pong = pong;

            this.Ping.EventPing += this.OnPingInvoked;
            this.Pong.EventPong += this.OnPongInvoked;

            this.Ping.DoPing();
        }
        
        public void OnPingInvoked(object sender, EventArgs e)
        {
            this.Pong.DoPong();
        }

        public void OnPongInvoked(object sender, EventArgs e)
        {
            this.Ping.DoPing();
        }
    }
}
