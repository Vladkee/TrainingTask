using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            AddSecondsToHours();
        }

        public static void AddSecondsToHours()
        {
            Console.WriteLine("Enter seconds");
            int seconds = Int32.Parse(Console.ReadLine());
            int hours = seconds / 3600;
            Console.WriteLine($"{hours} hour(s) have passed from the start of the day");
        }
    }
}
