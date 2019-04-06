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
            //AddSecondsToHours();

            Numbers();
        }

        public static void AddSecondsToHours()
        {
            Console.WriteLine("Enter seconds");
            int seconds = Int32.Parse(Console.ReadLine());
            int hours = seconds / 3600;
            Console.WriteLine($"{hours} hour(s) have passed from the start of the day");
        }

        public static void Numbers()
        {
            Console.WriteLine("Enter number A");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number B");
            int numberB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number C");
            int numberC = Convert.ToInt32(Console.ReadLine());

            if ((numberA > numberB) && (numberC < numberB))
            {
                Console.WriteLine("Number B is located between A and C");
            }
            else if ((numberA < numberB) && (numberC > numberB))
            {
                Console.WriteLine("Number B is located between A and C");
            }
            else Console.WriteLine("Number B is not located between A and C");
        }

    }
}
