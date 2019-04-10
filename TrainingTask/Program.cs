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

            //CustomersRoutes();

            //SumBetweenAandB();

            //EvenNumbersInNumber();

            //AverageNumber();

            //SkiDistance();

            //SmartMultipliplication();

            SquareOfNumber();
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

        public static void SumBetweenAandB()
        {
            Console.WriteLine("Enter the first number:");
            var number1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            var number2 = Int32.Parse(Console.ReadLine());

            //
            // Odd numbers.
            //
            int firstNumber;
            string oddNumbers = "";
            int sum = 0;
            if (number1 < number2)
            {
                firstNumber = number1 + 1;
                while ((firstNumber > number1) & (firstNumber < number2))
                {
                    if (firstNumber % 2 != 0)
                    {
                        oddNumbers = oddNumbers + firstNumber + " ";
                    }
                    firstNumber++;
                }
                Console.WriteLine($"Odd numbers between {number1} and {number2} are {oddNumbers}\n");
            }
            else if (number1 > number2)
            {
                firstNumber = number2 + 1;
                while ((firstNumber > number2) & (firstNumber < number1))
                {
                    if (firstNumber % 2 != 0)
                    {
                        oddNumbers = oddNumbers + firstNumber + " ";
                    }
                    firstNumber++;
                }
                Console.WriteLine($"Odd numbers between {number1} and {number2} are {oddNumbers}\n");
            }

            //
            // Sum of the numbers.
            //
            if (number1 < number2)
            {
                firstNumber = number1 + 1;
                while ((firstNumber > number1) & (firstNumber < number2))
                {
                    sum = sum + firstNumber;
                    firstNumber++;
                }
                Console.WriteLine($"Sum of the numbers between {number1} and {number2} are {sum}");
            }
            else if (number1 > number2)
            {
                firstNumber = number2 + 1;
                while ((firstNumber > number2) & (firstNumber < number1))
                {
                    sum = sum + firstNumber;
                    firstNumber++;
                }
                Console.WriteLine($"Sum of the numbers between {number1} and {number2} are {sum }");
            }
        }

        public static void EvenNumbersInNumber()
        {
            Console.WriteLine("Enter a number:");
            var number = Int32.Parse(Console.ReadLine()); //123
            int temp;
            int count = 0;
            string strCount = "";

            while (number > 0)
            {
                temp = number; //123 //12 //1
                temp %= 10; //3 //2 //1
                number /= 10; //12
                if (temp % 2 == 0)
                {
                    strCount = strCount + temp + " ";
                    count++;
                }
            }
            Console.WriteLine($"{count} even number(s) in your number is/are {strCount}");
        }

        public static void AverageNumber()
        {
            Console.WriteLine("Enter the first number:");
            var number1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            var number2 = Int32.Parse(Console.ReadLine());

            int firstNumber;
            int sum = 0;
            int average = 0;
            int count = 0;

            if (number1 <= number2)
            {
                firstNumber = number1 + 1;
                while ((firstNumber > number1) & (firstNumber < number2))
                {
                    count++;
                    sum = sum + firstNumber;
                    firstNumber++;
                }
                average = sum / count;
                Console.WriteLine($"Sum of the numbers between {number1} and {number2} is {sum} and average is {average}");
            }
            else if (number1 >= number2)
            {
                firstNumber = number2 + 1;
                while ((firstNumber > number2) & (firstNumber < number1))
                {
                    count++;
                    sum = sum + firstNumber;
                    firstNumber++;
                }
                average = sum / count;
                Console.WriteLine($"Sum of the numbers between {number1} and {number2} is {sum} and average is {average}");
            }
        }

        public static void SkiDistance()
        {
            double distance = 10;
            double sum = 10;
            int day = 1;
            while (sum < 90)
            {
                day++;
                distance = distance * 0.1 + distance;
                sum = sum + distance;
             Console.WriteLine($"{day} day = {distance} km");
            }
            Console.WriteLine();
            Console.WriteLine($"The distance is {sum} km for {day} days\n");
            Console.WriteLine($"On {day+1} day the distance will be 100km");
        }

        public static void SmartMultipliplication()
        {
            Console.WriteLine("Enter the first number:");
            var number1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            var number2 = Int32.Parse(Console.ReadLine());
            int counter = 0;
            int multiplication = 0;

            if (number2 < 0)
            {
                number2 = number2 * -1;
            }
            if (number1 < 0)
            {
                number1 = number1 * -1;
            } 
            while (counter < number2)
            {
                multiplication = multiplication + number1;
                counter++;
            }
            Console.WriteLine($"Number {number1} * {number2} = {multiplication}");
        }

        public static void SquareOfNumber()
        {
            Console.WriteLine("Enter a number:");
            var endNumber = Int32.Parse(Console.ReadLine());
            int square;
            string strSquare = "";

            //
            // Квадраты чисел не больше указанного числа.
            //
            for (int i = 1; i < endNumber; i++)
            {
                square = i * i;
                if (square > endNumber) break;
                strSquare = strSquare + square + " ";
            }
            Console.WriteLine(strSquare);

            //
            // Квадраты чисел до указанного числа.
            //
            //for (int i = 1; i < endNumber; i++)
            //{
            //    square = i * i;
            //    strSquare = strSquare + square + " ";
            //}
            //Console.WriteLine(strSquare);

        }
    }
}
