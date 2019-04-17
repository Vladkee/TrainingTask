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

            //Array3();

            //Array4();

            //MyReverse();

            //SubArray(GetArray(10), 6, 6);

            //IncreaseArray(GetArray(10), 7);

            RepeatedXinArray();

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

        public static int[] GetArray(int size)
        {
            var random = new Random();
            var array = new int[size];

            for (int i = 0; i < size; i++)
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
            int[] array = new int[] { 1, 3, 6, 3, 6, 2, 4, 8 };
            Console.WriteLine(string.Join(",", array));
            Console.WriteLine();
            int sum = 0;
            int arithmetic = 0;
            string strArray = "";

            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            Console.WriteLine($"Sum = {sum}.\n");

            arithmetic = sum / array.Length;
            Console.WriteLine($"Arithmetic number is {arithmetic}.\n");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > arithmetic)
                {
                    strArray += array[i] + " ";
                }
            }
            Console.WriteLine($"Numbers {strArray} more arithmetic number {arithmetic}.");
        }

        public static void MyReverse()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int temp = 0;
            int length = array.Length;
            Console.WriteLine("Array before:");
            Console.WriteLine(string.Join(",", array));
            Console.WriteLine();

            for (int i = 0, j = length - 1; i < j & j < length; i++, j--)
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
            Console.WriteLine("Array after:");
            Console.WriteLine(string.Join(",", array));
        }

        public static int[] SubArray(int[] array, int index, int count)
        {
            Console.WriteLine(string.Join(",", array));
            Console.WriteLine();

            int[] array2 = new int[count];
            int size = count + index;

            for (int i = 0; i < count; i++)
            {
                if (size > array.Length)
                {
                    while (index + i < array.Length)
                    {
                        array2[i] = array[index + i];
                        i++;
                    }
                }
                else
                {
                    array2[i] = array[index + i];
                }
            }
            Console.WriteLine(string.Join(",", array2));
            Console.WriteLine();

            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] == 0)
                {
                    array2[i] = 1;
                }
            }
            Console.WriteLine(string.Join(",", array2));

            return array;
        }

        public static int[] IncreaseArray(int[] array, int value)
        {
            Console.WriteLine("Array before:");
            Console.WriteLine(string.Join(",", array));
            Console.WriteLine();

            int[] array2 = new int[array.Length + 1];

            array2[0] = value; //7
            for (int i = 1, j = 0; i < array2.Length; i++, j++)
            {
                array2[i] = array[j];
            }
            Console.WriteLine("Array after:");
            Console.WriteLine(string.Join(",", array2));

            return array;
        }

        public static void RepeatedXinArray()
        {
            int[,] array = new int[,] { { 9, 5, 3, 4, 6, 7, 8 }, { 6, 3, 1, 3, 2, 7, 3 } };
            int counter = 0;

            Console.WriteLine("Enter the X number:");
            var xNumber = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    if (array[i, k] == xNumber)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine($"The X number {xNumber} repeated {counter} times");
        }
    }
}

