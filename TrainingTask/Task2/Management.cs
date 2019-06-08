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

				}
				else if (accNumber == item.AccountNumber && item is CardAccount4)
				{
					Console.WriteLine("It's a card account. You can do the next operations:");
					Console.WriteLine("1 - Charge interest");
					Console.WriteLine("2 - Get money");
					Console.WriteLine("3 - Deposit money");

					string decision = Console.ReadLine();

					Console.WriteLine($"Your current balance is {item.GetCurrentBalance()}$.");

					if (decision == "1")
					{
						
					}
					else if(decision == "2")
					{

					}
					else if (decision == "3")
					{

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
