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

            //
            //Task 4 activation.
            //
            short num1 = 1000;
            short num2 = 1500;

            Console.WriteLine($"{num1} + {num2} = {Program.Sum(num1, num2)}");
            //
            //Task 5 activation.
            //
            int i1 = 455;
            int i2 = 84500;
            decimal dec = 7.98845m;

            //
            // Приводим два числа типа int к типу short.
            // Тип данных short имеет диапазон около 32 000, поэтому в итоге мы получаем остаток числа - 18964.
            //
            Console.WriteLine((short)i1);
            Console.WriteLine((short)i2);

            //
            // Приводим число типа decimal к типу int.
            // Тип decimal должен содержать число с плавающей точкой, но так как int это целочисленный тип, то при выводе он обрезает значение до целого числа.
            //
            Console.WriteLine((int)dec);
            */
            Task6();
        }
        //
        //Square calculation (Task 7)
        //
        public static decimal PerformCalculation(int r)
        {
            const decimal Pi = 3.14m;
            decimal square = Pi * r * r;
            return square;
        }
        //
        //Part of task 4.
        //
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        //
        //Вывод: больший тип данных мы не можем перевести в меньший. (short > int = OK; long > int = ERROR)
        //

        public static void Task6()
        {
            double aver;
            int num1 = 10;
            int num2 = 13;
            int num3 = 15;
            aver = (double)(num1 + num2 + num3) /3;
            Console.WriteLine("Среднее арифметическое число " + aver);
            //
            //Основной проблемой является "обрезание" числа. Ср. ариф. должно выйти около 12.666. Тип int обрезает и округляет число до целых без округления в большую сторону.
            //
        }
       

    }
}
