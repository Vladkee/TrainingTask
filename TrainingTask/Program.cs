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
            //PrimeNumber();

            CustomersRoutes();
        }

        public static void PrimeNumber()
        {
            Console.WriteLine("Enter a number:");
            var number = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] mas1 = new int[] { 2, 3, 5, 6, 9 };
            string dividers = "";
            if (number % 2 == 0) Console.WriteLine($"Number {number} is even\n");
            else Console.WriteLine($"Number {number} is odd\n");

            //
            // Dividers of the number.
            //
            for (int k = 0; k < mas1.Length; k++)
            {
                if (number % mas1[k] == 0)
                {
                    dividers = dividers + mas1[k] + " ";
                }
            }
            if ((number % 2 == 0) || (number % 3 == 0) || (number % 5 == 0) || (number % 6 == 0) || (number % 9 == 0))
            {
                Console.WriteLine($"Number {number} is divided by {dividers}\n");
            }
            else Console.WriteLine($"You cannot divide the number {number} by 2,3,5,6,9.\n");

            //
            // IsPrime?
            //
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0) count++;
            }
            if (count == 2) Console.WriteLine("Your number is prime\n");
            else Console.WriteLine("Your number is not prime\n");
        }

        public static void CustomersRoutes()
        {
            Console.WriteLine("How many customers?");
            var customers = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            int routes = 1;
            do
            {
                routes = routes * customers;
                customers--;
            } while (customers > 0);
            Console.WriteLine($"{routes} routes.");
        }
    }
}
