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
            //UniqueSymbol();

            DeleteDuplicatesInRow();

            //InsertedText();

            //DeletedSpaceBetweenQuestionSymbols();

            //DeletedExtraSpaces();

            //ExactWordinText();

            //SwapText();

            //GetMaxAndMinSizeOfWords();
        }

        public static void UniqueSymbol()
        {
            string text = "123Привет123Привет";
            Console.WriteLine(text);
            char symbol = '1';
            int counterSymbol = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == symbol)
                {
                    counterSymbol++;
                }
            }
            Console.WriteLine($"The symbol {symbol} repeated {counterSymbol} times.");
        }

        public static void DeleteDuplicatesInRow()
        {
            string text = "123425123";

            string newText = string.Empty;


            for (int i = 0; i < text.Length; i++)
            {
                for (int y = i+1; y < text.Length; y++)
                {
                    if (text[y] == text[i])
                    {
                        newText = text.Remove(y, 1);
                        text = newText;
                    }
                }
            }
            Console.WriteLine(text);
        }

        public static void InsertedText()
        {
            string text1 = "Main TEXT";
            string text2 = "Pasted text ";

            Console.WriteLine($"Before: {text1}");
            string resultText = text1.Insert(5, text2);
            Console.WriteLine($"After: {resultText}");
        }

        public static void DeletedSpaceBetweenQuestionSymbols()
        {
            string text = "Be? ? Or no to be?";
            Console.WriteLine(text);

            string trimText = text.Remove(3, 1);
            Console.WriteLine(trimText);
        }

        public static void DeletedExtraSpaces()
        {
            string text = "Be??  Or  no  to  be?";
            Console.WriteLine(text);
            string textWithoutSpaces = "";

            //string[] textWithDeletedSpaces = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(string.Join(" ", textWithDeletedSpaces));

            string[] newTextWithDeletedSpaces = text.Split(new char[] { ' ' });
            for (int i = 0; i < newTextWithDeletedSpaces.Length; i++)
            {
                if (newTextWithDeletedSpaces[i] != string.Empty)
                {
                    textWithoutSpaces += newTextWithDeletedSpaces[i] + " ";
                }
            }
            Console.WriteLine(textWithoutSpaces);
        }

        public static void ExactWordinText()
        {
            string text = "Be?? Or no to be?";
            Console.WriteLine(text);
            Console.Write("Enter the index: ");
            var index = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            string[] arrayText = text.Split(' ');
            Console.WriteLine($"The word with index {index} is \"{arrayText[index]}\".");
            string word = arrayText[index];

            string letter = word.Substring(0, 1);
            Console.WriteLine($"The first symbol of \"{word}\" is \"{letter}\".");
        }

        public static void SwapText()
        {
            Console.WriteLine("Enter some text:");
            var someText = Console.ReadLine();

            string[] arrayOfSomeText = someText.Split(' ');
            int arrayLenght = arrayOfSomeText.Length;
            string temp = string.Empty;

            for (int i = 0, j = arrayLenght - 1; i < j & j < arrayLenght; i++, j--)
            {
                temp = arrayOfSomeText[i];
                arrayOfSomeText[i] = arrayOfSomeText[j];
                arrayOfSomeText[j] = temp;
            }
            Console.WriteLine("Swapped text looks like:");
            Console.WriteLine(string.Join(" ", arrayOfSomeText));
        }

        public static void GetMaxAndMinSizeOfWords()
        {
            Console.WriteLine("Enter some text:");
            var someText = Console.ReadLine();

            string[] arrayOfSomeText = someText.Split(' ');
            int maxSize = arrayOfSomeText[0].Length;
            string maxSizeWord = string.Empty;
            int minSize = arrayOfSomeText[0].Length;
            string minSizeWord = string.Empty;

            for (int i = 0; i < arrayOfSomeText.Length; i++)
            {
                if (maxSize < arrayOfSomeText[i].Length)
                {
                    maxSize = arrayOfSomeText[i].Length;
                    maxSizeWord = arrayOfSomeText[i];
                }

                if (minSize > arrayOfSomeText[i].Length)
                {
                    minSize = arrayOfSomeText[i].Length;
                    minSizeWord = arrayOfSomeText[i];
                }
            }
            Console.WriteLine($"The longest word is '{maxSizeWord}' with lenght {maxSize} and the shortest word is '{minSizeWord}' with lenght {minSize}");
        }
    }
}
