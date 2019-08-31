using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2Hunter
{
    public class Hunter
    {
        public void PrintRabbitLocation(int coordinateX, int coordinateY)
        {
            Console.WriteLine($"Rabbit was catched on coordinates{Environment.NewLine}" +
                $"X: {coordinateX}{Environment.NewLine}" +
                $"Y: {coordinateY}{Environment.NewLine}");
        }
    }
}
