using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2
{
	class Worker
	{
		public static List<BankAccount> CreateAccount()
		{
			List<BankAccount> listOfAccounts = new List<BankAccount>();
			int position = 0;


			while (true)
			{
				Console.WriteLine("What type of account would you like to create?");
				Console.WriteLine("1 - Deposit account; 2 - Card account");
				string decisionType = Console.ReadLine();

				if (decisionType == "1")
				{
					Console.WriteLine("Ok. Deposit account will be created.");
					Console.WriteLine("Please, enter your name (ex. 'Alex Konow').");
					string name = Console.ReadLine();
					position++;
					Console.WriteLine("How much do you want to deposit on the account?");
					string strDepositMoney = Console.ReadLine();
					decimal.TryParse(strDepositMoney, out decimal depositMoney);

					listOfAccounts.Add(new DepositAccount2(depositMoney, name, position));

				}
				else if (decisionType == "2")
				{
					Console.WriteLine("Ok. Card account will be created.");
					Console.WriteLine("Please, enter your name (ex. 'Alex Konow').");
					string name = Console.ReadLine();
					position++;
					Console.WriteLine("How much do you want to deposit on the account?");
					string strDepositMoney = Console.ReadLine();
					decimal.TryParse(strDepositMoney, out decimal depositMoney);

					listOfAccounts.Add(new CardAccount4(depositMoney, name, position));
				}
				else
				{
					throw new Exception("Wrong option. Try again!");
				}

				Console.WriteLine("Would you like to create another one? (Use 'y' or 'n')");
				string createDecision = Console.ReadLine();

				if (createDecision == "y")
				{
					continue;
				}
				else if (createDecision == "n")
				{
					break;
				}
				else
				{
					throw new Exception("Wrong option. Try again!");
				}
			}
			return listOfAccounts;
		}

		public static void ViewInfoOfAccounts(List<BankAccount> listOfAccounts)
		{
			Console.Clear();

			foreach (var item in listOfAccounts)
			{
				Console.WriteLine($"Account number is: {item.AccountNumber}");
				Console.WriteLine($"Accout type is: {item.GetType().Name}");
				Console.WriteLine($"Account owner is: {item.Owner}");
				Console.WriteLine($"Account balance is: {item.Balance}");
				Console.WriteLine(string.Empty);
			}
		}

		public static int ChooseAccountNumberToWorkWith()
		{
			Console.WriteLine("What do you want to work with? (use account number)");
			string decision = Console.ReadLine();
			Int32.TryParse(decision, out int accNumber);

			Console.Clear();
			Console.WriteLine($"Ok. Lets see that we can do with account number {accNumber}.");

			return accNumber;
		}

	}
}
