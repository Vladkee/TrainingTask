using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task1PingPong
{
    public class GameManager
    {
        public Ping Ping { get; set; }

        public Pong Pong { get; set; }

        public GameManager(Ping ping, Pong pong)
        {
            this.Ping = ping;
            this.Pong = pong;

            this.Ping.EventPing += this.OnPingInvoked;
            this.Pong.EventPong += this.OnPongInvoked;

            this.Ping.PrintPing();
        }

        public void OnPingInvoked(object sender, EventArgs e)
        {
            this.Pong.PrintPong();
        }

        public void OnPongInvoked(object sender, EventArgs e)
        {
            this.Ping.PrintPing();
        }
    }
}
