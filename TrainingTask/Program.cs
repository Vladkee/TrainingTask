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
            /*
            Console.WriteLine("Hello World");
            Console.Write("Add radius ");
            string radiusString = Console.ReadLine();

            int.TryParse(radiusString, out int radius);
        
            Console.WriteLine($"The square of the round is {Program.PerformCalculation(radius)}");
            */
            //HomeTask1();
            //HomeTask2();
            //HomeTask3();
            //HomeTask4();
            //HomeTask5();
            //HomeTask6();
            HomeTask7();

        }
        public static decimal PerformCalculation(int r)
        {
            const decimal Pi = 3.14m;
            decimal square = Pi * r * r;
            return square;
        }
        public static void HomeTask1()
        {
            int x1 = 5;
            Console.WriteLine(x1);
        }
        public static void HomeTask2()
        {
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            string hello = "Привет, " + name;
            Console.WriteLine(hello);
        }
        public static void HomeTask3()
        {
            var v1 = 'v';
            v1 = 'V';
            Console.WriteLine($"{v1} means Vendetta");
            //
            //Инициализируя переменную v1, используя неявную типизацию, при этом применяя значение типа char, мы исключаем возможность изменить значение переменной на другое (не char).
            //Такое же правило действует и для явной типизации.
            //
        }
        public static void HomeTask4()
        {
            Console.WriteLine("Введите длину стороны квадрата:");
            string side = Console.ReadLine();
            int intSide1 = Convert.ToInt32(side);
            int intSide2 = Int32.Parse(side);
            int perimetr = 4 * intSide1;
            Console.WriteLine("Периметр квадрата равен:" + perimetr);
        }
        public static void HomeTask5()
        {
            const double Pi = 3.14;
            double r1 = 5.3;
            double r2 = 3.2;
            var square1 = Pi * r1 * r1;
            var square2 = Pi * r2 * r2;
            var square3 = square1 - square2;
            Console.WriteLine("Площадь круга S1 равна " + square1);
            Console.WriteLine("Площадь круга S2 равна " + square2);
            Console.WriteLine("Площадь круга S3 равна " + square3);
        }
        public static void HomeTask6()
        {
            int number = 23;
            int right = number / 10;
            int left = number % 10;
            Console.WriteLine($"Правое число: {right}. Левое число: {left}.");
        }
        public static void HomeTask7()
        {
            int n1 = 20000;
            int n2 = 6000;
            long sum = n1 + n2;
            Console.WriteLine(sum);
        }
    }
}
