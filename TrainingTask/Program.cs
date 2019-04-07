﻿using System;
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

            //IsNumberOdd();

            //OperationsWithNumbers();

            //ConsoleCalculator();

            //Range0to100();

            //WeatherTranslate();

            //BonusCalculation();

            //ConsoleCalculatorVer2();

            //Factorial();

            SignPicture();
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
                Console.WriteLine("Number B between A and C");
            }
            else Console.WriteLine("Number B located between A and C");
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

        public static void OperationsWithNumbers()
        {
            int x = 10;
            int y = 12;
            int z = 3;

            x += y - x++ * z; Console.WriteLine($"Operation with x =: {x}");
            z = --x - y * 5; Console.WriteLine($"Operation with z =: {z}");
            y /= x + 5 % z; Console.WriteLine($"Operation with y =: {y}");
            z = x++ + y * 5; Console.WriteLine($"Operation with z =: {z}");
            x = y - x++ * z; Console.WriteLine($"Operation with x =: {x}");
        }

        public static void ConsoleCalculator()
        {
            int operand1 = 100;
            int operand2 = 10;
            //
            // To divide by 0 change operand2 to 0. 
            //
            Console.WriteLine("Please enter an arithmetic sign (+,-,*,/,%)");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    int sum = operand1 + operand2;
                    Console.WriteLine($"Sum of numbers is {sum}");
                    break;
                case "-":
                    int difference = operand1 - operand2;
                    Console.WriteLine($"Difference of numbers is {difference}");
                    break;
                case "*":
                    int multiplication = operand1 * operand2;
                    Console.WriteLine($"Multiplication of numbers is {multiplication}");
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Cannot be divided by null");
                    }
                    else
                    {
                        int division = operand1 / operand2;
                        Console.WriteLine($"Division of numbers is {division}");
                    }
                    break;
                case "%":
                    int remainderOfDivision = operand1 % operand2;
                    Console.WriteLine($"Sum of numbers is {remainderOfDivision}");
                    break;
                default:
                    Console.WriteLine("You have entered a wrong symbol");
                    break;
            }
        }

        public static void Range0to100()
        {
            Console.WriteLine("Enter a number between 0 and 100.");
            int number = Int32.Parse(Console.ReadLine());
            if (number < 0 && number > 100)
            {
                Console.WriteLine("ERROR: You have entered a wrong number.");
            }
            if (number >= 0 && number <= 14)
            {
                Console.WriteLine("Your number located between 0 and 14.");
            }
            if (number >= 15 && number <= 35)
            {
                Console.WriteLine("Your number located between 15 and 35.");
            }
            if (number >= 36 && number <= 50)
            {
                if (number >= 36 && number <= 49) Console.WriteLine("Your number located between 36 and 50.");
                if (number == 50) Console.WriteLine("Your number located between [36-50] & [50-100].");
            }
            if (number > 50 && number <= 100)
            {
                Console.WriteLine("Your number located between 50 and 100.");
            }
        }

        public static void WeatherTranslate()
        {
            Console.WriteLine("Enter a word with weather meaning in russian (солнце, дождь, ...");
            string word = Console.ReadLine();
            switch (word)
            {
                case "солнце":
                    Console.WriteLine("Translation for word 'солнце' is 'sun'");
                    break;
                case "радуга":
                    Console.WriteLine("Translation for word 'радуга' is 'rainbow'");
                    break;
                case "дождь":
                    Console.WriteLine("Translation for word 'дождь' is 'rain'");
                    break;
                case "снег":
                    Console.WriteLine("Translation for word 'снег' is 'snow'");
                    break;
                case "ветер":
                    Console.WriteLine("Translation for word 'ветер' is 'wind'");
                    break;
                case "лето":
                    Console.WriteLine("Translation for word 'лето' is 'summer'");
                    break;
                case "температура":
                    Console.WriteLine("Translation for word 'температура' is 'temperature'");
                    break;
                case "зима":
                    Console.WriteLine("Translation for word 'зима' is 'winter'");
                    break;
                case "весна":
                    Console.WriteLine("Translation for word 'весна' is 'spring'");
                    break;
                case "осень":
                    Console.WriteLine("Translation for word 'осень' is 'fall'");
                    break;
                default:
                    Console.WriteLine("The is no translation for this word.");
                    break;
            }
        }

        public static void BonusCalculation()
        {
            Console.WriteLine("Enter a long service of a person:");
            var age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter a salary of a person:");
            var salary = Int32.Parse(Console.ReadLine());
            double bonus;
            if (age > 0 && age < 5)
            {
                bonus = salary * 0.1 + salary;
                Console.WriteLine($"Your bonus is 10%. Your salary will be {bonus}.");
            }
            else if (age >= 5 && age < 10)
            {
                bonus = salary * 0.15 + salary;
                Console.WriteLine($"Your bonus is 15%. Your salary will be {bonus}.");
            }
            else if (age >= 10 && age < 15)
            {
                bonus = salary * 0.25 + salary;
                Console.WriteLine($"Your bonus is 25%. Your salary will be {bonus}.");
            }
            else if (age >= 15 && age < 20)
            {
                bonus = salary * 0.35 + salary;
                Console.WriteLine($"Your bonus is 35%. Your salary will be {bonus}.");
            }
            else if (age >= 20 && age < 25)
            {
                bonus = salary * 0.45 + salary;
                Console.WriteLine($"Your bonus is 45%. Your salary will be {bonus}.");
            }
            else if (age >= 25)
            {
                bonus = salary * 0.5 + salary;
                Console.WriteLine($"Your bonus is 50%. Your salary will be {bonus}.");
            }
        }

        public static void ConsoleCalculatorVer2()
        {
            int operand1;
            int operand2;
            while (true)
            {
                Console.WriteLine("Enter the first number:");
                string strOperand1 = Console.ReadLine();
                if (string.IsNullOrEmpty(strOperand1) || !Int32.TryParse(strOperand1, out operand1))
                {
                    Console.WriteLine("Please, enter a valid number.");
                    Console.Clear();
                    continue;
                }
                operand1 = Int32.Parse(strOperand1);

                Console.WriteLine("Enter the second number:");
                string strOperand2 = Console.ReadLine();
                if (string.IsNullOrEmpty(strOperand2) || !Int32.TryParse(strOperand2, out operand2))
                {
                    Console.WriteLine("Please, enter a valid number.");
                    Console.Clear();
                    continue;
                }
                operand2 = Int32.Parse(strOperand2);

                Console.WriteLine("Please enter an arithmetic sign (+,-,*,/,%).");
                ArithmeticSignTimeStamp:
                string sign = Console.ReadLine();
                switch (sign)
                {
                    case "+":
                        int sum = operand1 + operand2;
                        Console.WriteLine($"Sum of numbers is {sum}");
                        break;
                    case "-":
                        int difference = operand1 - operand2;
                        Console.WriteLine($"Difference of numbers is {difference}");
                        break;
                    case "*":
                        int multiplication = operand1 * operand2;
                        Console.WriteLine($"Multiplication of numbers is {multiplication}");
                        break;
                    case "/":
                        if (operand2 == 0)
                        {
                            Console.WriteLine("Cannot be divided by null");
                            break;
                        }
                        else
                        {
                            int division = operand1 / operand2;
                            Console.WriteLine($"Division of numbers is {division}");
                        }
                        break;
                    case "%":
                        if (operand2 == 0)
                        {
                            Console.WriteLine("Cannot be divided by null");
                            break;
                        }
                        else
                        {
                            int remainderOfDivision = operand1 % operand2;
                            Console.WriteLine($"Reminder of division of numbers is {remainderOfDivision}");
                        }
                        break;
                    default:
                        Console.WriteLine("You have entered a wrong symbol. Enter a valid sign.");
                        goto ArithmeticSignTimeStamp;

                        //
                        // Sorry for 'goto'. I cannot imagine the better option how to avoid moving to start point ff i would used 'continue'. 
                        //
                }
                Console.WriteLine("Would you like to continue? Press 'y' or 'n'.");
                string decision = Console.ReadLine();
                if (decision == "y") continue;
                if (decision == "n") break;
                if (decision != "y" || decision != "n")
                {
                    Console.WriteLine("You have entered wrong key word.");
                    break;
                }
            }
        }

        public static void Factorial()
        {
            int factorial = 1;
            Console.WriteLine("Enter a number:");
            var number = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                factorial = i * factorial;
            }
            Console.WriteLine($"Factorial {number} is {factorial}");
        }

        public static void SignPicture()
        {
            //
            // Single line.
            //
            for (int i = 0; i < 20; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n\n");

            //
            // Rectangle.
            //
            for (int i = 0; i < 20; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
            for (int i = 0; i < 2; i++)
            {
                Console.Write("*");
                for (int k = 0; k < 18; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("*\n");
            }
            for (int i = 0; i < 20; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n\n");

            //
            // Right triangle.
            //
            Console.Write("*\n");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("*");
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("*\n");
            }
            for (int i = 0; i < 7; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n\n");

            //
            // Equilateral triangle. Решение подглядел в интернете, но понял и переделал под себя. Не могу понять только почему большая пустота сверху треугольника.
            //
            for (int i = 0; i < 16; i++) // i - amount of symbols.
            {
                Console.Write("\n");
                for (int j = 0, k = 16; j < 16 && k > 0; k--, j++) // j - amount of spaces. k - amount of '*'.
                {
                    if (i < k || i < j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
            }
            Console.Write("\n\n");

            //
            // Rhombus.
            //
            for (int i = 0; i < 16; i++) // i - amount of symbols.
            {
                Console.Write("\n");
                for (int j = 0, k = 16; j < 16 && k > 0; k--, j++) // j - amount of spaces. k - amount of '*'.
                {
                    if (i < k || i < j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
            }
            for (int i = 0; i < 16; i++) // i - amount of symbols.
            {
                Console.Write("\n");
                for (int j = 0, k = 16; j < 16 && k > 0; k--, j++) // j - amount of spaces. k - amount of '*'.
                {
                    if (i > k || i > j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
            }
        }
    }
}
