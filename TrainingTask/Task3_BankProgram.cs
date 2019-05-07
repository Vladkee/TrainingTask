using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
    public static class Task3_BankProgram
    {
        public static void BodyProgram()
        {
            decimal debt = Debt();
            decimal payment = GetPayment();
            decimal difference = CalculationDebt(debt, payment);
            ComparisonDebt(difference);
        }

        private static decimal Debt()
        {
            Console.Write("Enter a debt: ");

            while (true)
            {
                string strDebt = Console.ReadLine();
                bool isNumber = Decimal.TryParse(strDebt, out decimal debt);
                if (!isNumber)
                {
                    Console.WriteLine("It's not a number.");
                    continue;
                }
                else
                    return debt;
            }
        }

        private static decimal GetPayment()
        {
            Console.Write("Enter amount of payment: ");

            while (true)
            {
                string strPayment = Console.ReadLine();
                bool isNumber = Decimal.TryParse(strPayment, out decimal payment);
                if (!isNumber)
                {
                    Console.WriteLine("It's not a number.");
                    continue;
                }
                else
                    return payment;
            }
        }

        private static decimal CalculationDebt(decimal debt, decimal payment)
        {
            decimal difference = debt - payment;

            return difference;
        }

        private static void ComparisonDebt(decimal difference)
        {
            if (difference > 0)
            {
                Console.WriteLine($"You have to pay {difference} more.");
            }
            else if (difference < 0)
            {
                difference *= -1;
                Console.WriteLine($"There is overpayment amount is {difference}.");
            }
            else
                Console.WriteLine("No debt left.");
        }

		private static void CheckATMPinCode()
		{

		}
    }
}
