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
            /*
            Console.WriteLine("Hello World");
            Console.Write("Add radius ");
            string radiusString = Console.ReadLine();

            int.TryParse(radiusString, out int radius);
        
            Console.WriteLine($"The square of the round is {Program.PerformCalculation(radius)}");
            */

            //
            //task 4 activation
            //
            short num1 = 1000;
            short num2 = 1500;

            Console.WriteLine($"{num1} + {num2} = {Program.Sum(num1, num2)}");
            
        }

        public static decimal PerformCalculation(int r)
        {
            const decimal Pi = 3.14m;
            decimal square = Pi * r * r;
            return square;
        }
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        //
        //Вывод: больший тип данных мы не можем перевести в меньший. (short > int = OK; long > int = ERROR)
        //


    }
}
