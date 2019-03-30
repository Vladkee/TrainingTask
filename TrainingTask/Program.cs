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
            /*Console.WriteLine("Hello World");
            Console.Write("Add radius ");
            string radiusString = Console.ReadLine();

            int.TryParse(radiusString, out int radius);
        
            Console.WriteLine($"The square of the round is {Program.PerformCalculation(radius)}");
            */
            int final = 0;
            Console.WriteLine($"Sum is {Program.TestInitialization(final)}");
        }

        public static decimal PerformCalculation(int r)
        {
            const decimal Pi = 3.14m;
            decimal square = Pi * r * r;
            return square;
        }
        public static int TestInitialization(int final)
        {
            int uberflu = 1;
            int _Identifier = 2;
            int \u006fldentifier = 3;
            int myVar = 4;
            int myVariab1le = 5;

            final = uberflu +_Identifier + \u006fldentifier + myVar + myVariab1le;
            return final;
        }
        
    }
}
