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
            Massive();
        }

        public static void Massive()
        {
            Console.WriteLine("Enter a size of array:");
            var size = Int32.Parse(Console.ReadLine());
            int[] array = new int[size];
            var random = new Random();
            int sum = 0;
            int arithmetic = 0;
            string strOddNumbers = "";

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 10);
            }
            Console.WriteLine(string.Join(",", array));
            Console.WriteLine();

            int max = array[0];
            int min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            Console.WriteLine($"Sum = {sum}.\n");

            arithmetic = sum / size;
            Console.WriteLine($"Arithmetic number is {arithmetic}.\n");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    strOddNumbers += array[i] + " "; 
                }
            }
            Console.WriteLine($"Odd numbers: {strOddNumbers}\n");

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i]) max = array[i];
                if (max > array[i]) min = array[i];
            }
            Console.WriteLine($"max = {max}, min = {min}");
        }
    }
}
