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
            //HomeTask1();
            //HomeTask2();
            HomeTask3();

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
    }
}
