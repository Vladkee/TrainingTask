using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2
{
	class Management
	{
		public void Execute()
		{
			//DepositAccount2 acc1 = new DepositAccount2(1000.00m, "Alex Konow", 1);
			//CurrentAccount3 acc2 = new CurrentAccount3(2000.00m, "Dima Tulin", 2);


			List<BankAccount> listOfAccounts = Worker.CreateAccount();

			Worker.ViewInfoOfAccounts(listOfAccounts);

			int accNumber = Worker.ChooseAccountNumberToWorkWith();

			foreach (var item in listOfAccounts)
			{
				if (accNumber == item.AccountNumber && item is DepositAccount2)
				{
					Console.WriteLine("It's a deposit account. Choose the next operation:");
					Console.WriteLine("1 - Choose Rate");
					Console.WriteLine("2 - Charge interest");

					string depDecision = Console.ReadLine();

					Console.WriteLine($"Your current balance is {item.GetCurrentBalance()}$.");

					if (depDecision == "1")
					{
						((DepositAccount2)item).ChooseRate();
					}
					else if (depDecision == "2")
					{
						((DepositAccount2)item).ChargeInterest();
						Console.WriteLine("Would you like to check current balance? ('y' or 'n')");
						string checkBalanceDecision = Console.ReadLine();
						if (checkBalanceDecision == "y")
						{
							Console.WriteLine($"You current balance is {item.GetCurrentBalance()}$");
						}
						else if (checkBalanceDecision == "n")
						{
							break;
						}
					}
					else
					{
						throw new Exception("Wrong option.Try Again!");
					}
				}
				else if (accNumber == item.AccountNumber && item is CardAccount4)
				{
					Console.WriteLine("It's a card account. Choose the next operation:");
					Console.WriteLine("1 - Charge interest");
					Console.WriteLine("2 - Get money");
					Console.WriteLine("3 - Deposit money");

					string cardDecision = Console.ReadLine();

					Console.WriteLine($"Your current balance is {item.GetCurrentBalance()}$.");

					if (cardDecision == "1")
					{
						((CardAccount4)item).ChooseRate();
						((CardAccount4)item).ChargeInterest();

						Console.WriteLine("Would you like to check current balance? ('y' or 'n')");
						string checkBalanceDecision = Console.ReadLine();
						if (checkBalanceDecision == "y")
						{
							Console.WriteLine($"You current balance is {item.GetCurrentBalance()}$"); 
						}
						else if (checkBalanceDecision == "n")
						{
							break;
						}
					}
					else if(cardDecision == "2")
					{
						((CardAccount4)item).GetMoney();
					}
					else if (cardDecision == "3")
					{
						((CardAccount4)item).DepositMoney();
					}
					else
					{
						throw new Exception("Wrong option.Try Again!");
					}
				}
				
			}
		}
	}
}
