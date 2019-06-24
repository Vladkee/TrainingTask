﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2
{
	public class BankManagement
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
				if (accNumber == item.AccountNumber && item is DepositAccount)
				{
					Console.WriteLine("It's a deposit account. Choose the next operation:");
					Console.WriteLine("1 - Choose Rate");
					Console.WriteLine("2 - Charge interest");

					string depDecision = Console.ReadLine();

					Console.WriteLine($"Your current balance is {item.GetCurrentBalance()}$.");

					if (depDecision == "1")
					{
						Console.WriteLine("Let's choose your deposit time and rate.");
						Console.WriteLine("You have 3 option: #1 - 3 months (2%), #2 - 6 months (5%), #3 - 12 months (7%). (Use 1,2, or 3).");
						((IInterestCountable)item).ChooseRate();
					}
					else if (depDecision == "2")
					{
						((IInterestCountable)item).ChargeInterest();
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
				else if (accNumber == item.AccountNumber && item is CardAccount)
				{
					Console.WriteLine("It's a card account. Choose the next operation:");
					Console.WriteLine("1 - Charge interest");
					Console.WriteLine("2 - Get money");
					Console.WriteLine("3 - Deposit money");

					string cardDecision = Console.ReadLine();

					Console.WriteLine($"Your current balance is {item.GetCurrentBalance()}$.");

					if (cardDecision == "1")
					{
						Console.WriteLine("Let's choose your deposit time and rate.");
						Console.WriteLine("You have 3 option: #1 - 3 months (2%), #2 - 6 months (5%), #3 - 12 months (7%). (Use 1,2, or 3).");
						((IInterestCountable)item).ChooseRate();
						((IInterestCountable)item).ChargeInterest();

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
						Console.WriteLine("How much money would you like to get?");
						((IBalanceAccessible)item).GetMoney();
					}
					else if (cardDecision == "3")
					{
						Console.WriteLine("How much money would you like to deposit?");
						((IBalanceAccessible)item).DepositMoney();
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