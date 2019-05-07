using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
    public static class Task1_Calculation
    {
        public static void PerformCalculation()
        {
            int firstNumber = GetFirstValue();
            int secondNumber = GetSecondValue();
            string sign = GetSignValue();
            double result = CaseAnalise(sign, firstNumber, secondNumber);
            ShowResult(result);
        }

        private static int GetFirstValue()
        {
            Console.Write("Enter the firts number: ");
            var firstNumber = Int32.Parse(Console.ReadLine());

            return firstNumber;
        }

        private static int GetSecondValue()
        {
            Console.Write("Enter the second number: ");
            var secondNumber = Int32.Parse(Console.ReadLine());

            return secondNumber;
        }

        private static string GetSignValue()
        {
            Console.Write("Enter the type of calculation (+, -, *, /): ");
            var sign = Console.ReadLine();

            return sign;
        }

        private static double CaseAnalise(string sign, int firstNumber, int secondNumber)
        {
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
            return result;
        }
        
        private static double Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        private static double Sub(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        private static double Mul(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        private static double Div(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0)
            {
                Console.WriteLine("ERROR! You can't devide by 0.");
                return 0;
            }
            return firstNumber / secondNumber;
        }

        private static void ShowResult(double result)
        {
            Console.WriteLine($"The result of calculation is {result}");
        }
    }
}
