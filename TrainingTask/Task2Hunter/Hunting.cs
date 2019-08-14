using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2Hunter
{
    public class Hunting
    {
        public Hunter Hunter { get; set; }

        public Rabbit Rabbit { get; set; }

        public Hunting(Hunter hunter, Rabbit rabbit)
        {
            this.Hunter = hunter;
            this.Rabbit = rabbit;

            this.Rabbit.EventNewLocation += this.OnEventNewLocationInvoked;
            this.Rabbit.ChangeLocation();
        }

        public void OnEventNewLocationInvoked(object sender, HuntingEventArgs e)
        {
            this.Hunter.PrintRabbitLocation(e.FirstCoordinate, e.SecondCoordinate);
        }
    }
}
