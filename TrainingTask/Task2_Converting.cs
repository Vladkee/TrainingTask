using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
    public static class Task2_Converting
    {
        public static void ConvertingСurrency()
        {
            decimal sumOfMoney = InputMoney();
            string currency = InputCurrency();
            decimal result = CaseAnalise(currency, sumOfMoney);
            ShowResult(result);
        }

        private static decimal InputMoney()
        {
            Console.Write("Enter the sum of money in hryvnia: ");
            decimal sumOfMoney = Int32.Parse(Console.ReadLine());

            return sumOfMoney;
        }

        private static string InputCurrency()
        {
            Console.Write("Enter a currency to convert (euro, dollar, rub): ");
            string currency = Console.ReadLine();

            return currency;
        }

        private static decimal GetEuro(decimal sumOfMoney)
        {
            int rate = 30;
            return sumOfMoney / rate;
        }

        private static decimal GetDollar(decimal sumOfMoney)
        {
            int rate = 27;
            return sumOfMoney / rate;
        }

        private static decimal GetRub(decimal sumOfMoney)
        {
            int rate = 48;
            return sumOfMoney * rate;
        }

        private static decimal CaseAnalise(string currency, decimal sumOfMoney)
        {
            decimal result = 0;
            switch (currency)
            {
                case "euro":
                    result = Task2_Converting.GetEuro(sumOfMoney);
                    break;
                case "dollar":
                    result = Task2_Converting.GetDollar(sumOfMoney);
                    break;
                case "rub":
                    result = Task2_Converting.GetRub(sumOfMoney);
                    break;
                default:
                    Console.WriteLine("You've entered wrong currency.");
                    break;
            }
            return result;
        }

        private static void ShowResult(decimal result)
        {
            Console.WriteLine($"The result is {result}");
        }
    }
}
