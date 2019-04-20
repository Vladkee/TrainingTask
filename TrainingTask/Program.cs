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
            PerformCalculation();
        }

        public static void PerformCalculation()
        {
            Console.Write("Enter the firts number: ");
            var firstNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            var secondNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the type of calculation (+, -, *, /): ");
            var sign = Console.ReadLine();
            double result = 0;

            switch (sign)
            {
                case "+":
                    result = Sum(firstNumber, secondNumber);
                    break;
                case "-":
                    result = Sub(firstNumber, secondNumber);
                    break;
                case "*":
                    result = Mul(firstNumber, secondNumber);
                    break;
                case "/":
                    result = Div(firstNumber, secondNumber);
                    break;
                default:
                    Console.WriteLine("You've entered wrong sign.");
                    break;
            }
            Console.WriteLine($"Result = {result}");
        }

        private static double Sum(int a, int b)
        {
            return a + b;
        }

        private static double Sub(int a, int b)
        {
            return a - b;
        }

        private static double Mul(int a, int b)
        {
            return a * b;
        }

        private static double Div(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("ERROR! You can't devide by 0.");
                return 0;
            }
            return a / b;
        }
    }
}
