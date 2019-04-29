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

            //InsertedText();

            //DeletedSpaceBetweenQuestionSymbols();

            //DeletedExtraSpaces();

            //ExactWordinText();

			SwappedText();

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

		public static void SwappedText()
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

	}
}
