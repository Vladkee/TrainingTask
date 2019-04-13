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
            //Array1();

            //var array = Program.GetArray(10);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item + " ");
            //}

            //Console.WriteLine();
            //var updatedArray = Program.DeletDuplicates(array);
            //Console.WriteLine();
            //foreach (var item in updatedArray)
            //{
            //    Console.WriteLine(item + " ");
            //}

            Array3();

        }

        public static void Array1()
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

        public static int[] GetArray(int count)
        {
            var random = new Random();
            var array = new int[count];

            for (int i = 0; i < count; i++)
            {
                array[i] = random.Next(1, 20);
            }
            return array;
        }

        public static int[] DeletDuplicates(int[] array)
        {
            var arrayWithoutDuplicates = new int[array.Length];
            arrayWithoutDuplicates[0] = array[0];
            int position = 0;

            var isDuplicate = false;

            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < position + 1; j++)
                {
                    if (array[i] == arrayWithoutDuplicates[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    arrayWithoutDuplicates[position] = array[i];
                    position++;
                    isDuplicate = false;
                }
            }
            return arrayWithoutDuplicates;
        }

        public static void Array3()
        {
            int[] array = new int[] { 1, 6, 3, 7, 5, 6, 2 };
            Console.WriteLine("Enter the max number:");
            var max = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the min number:");
            var min = Int32.Parse(Console.ReadLine());
            string strIndex = "";

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < max && array[i] > min)
                {
                    strIndex += i + " ";
                }
            }
            Console.WriteLine($"Indexs {strIndex} inside range.");
        }

        public static void Array4()
        {

        }
    }
}

