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

            //Numbers();

            IsNumberOdd();
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

        public static void IsNumberOdd()
        {
            Console.WriteLine("Enter a 3-digit number");
            var strNumber = Console.ReadLine();
            int digit = strNumber.Length;
            if (digit != 3)
            {
                Console.WriteLine("You have entered not a 3-digit number. Please try again!");
            }
            int number = Int32.Parse(strNumber);
            if (number % 2 != 0)
            {
                Console.WriteLine($"Your number is odd!");
            }
            else Console.WriteLine($"Your number is even!");
        }
    }
}
