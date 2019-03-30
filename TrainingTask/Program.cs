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
            
            //task1 activation
            int final = 0;
            Console.WriteLine($"Sum is {Program.TestInitialization(final)}");
            
            //task2 activation
            Task2PiAndEyler();
            */
            //task3 activation
            Task3();



        }

        public static decimal PerformCalculation(int r)
        {
            const decimal Pi = 3.14m;
            decimal square = Pi * r * r;
            return square;
        }
        //task1
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
        //task2
        public static void Task2PiAndEyler()
        {
            const double Pi = 3.141592653;
            const double E = 2.7182818284590452;
            Console.WriteLine($"Number Pi is {Pi}. Number E is {E}");
        }
        //task3
        public static void Task3()
        {
            string first = "\nмоя строка 1";
            string second = "\tмоя строка 2";
            string third = "\aмоя строка 3";
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
        }


    }
}
