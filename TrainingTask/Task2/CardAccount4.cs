using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2
{
	class CardAccount4 : BankAccount, IChargableInterest1, IOperableAccount2
	{
		public double Rate { get; set; }

		public CardAccount4(decimal balance, string owner, int accountNumber)
			: base(balance, owner, accountNumber)
		{
			this.Rate = 0.00;
		}

		public double ChooseRate()
		{
			Console.WriteLine("Let's choose your deposit time and rate.");
			Console.WriteLine("You have 3 option: #1 - 3 months (2%), #2 - 6 months (5%), #3 - 12 months (7%). (Use 1,2, or 3).");

			string rateResult = Console.ReadLine();
			if (rateResult == "1")
			{
				this.Rate = 0.02;
			}
			else if (rateResult == "2")
			{
				this.Rate = 0.05;
			}
			else if (rateResult == "3")
			{
				this.Rate = 0.07;
			}
			else
			{
				throw new Exception("You chose wrong option. Try again.");
			}

			Console.WriteLine(string.Empty);
			Console.WriteLine($"Your rate is {this.Rate}.");

			return this.Rate;
		}

		public void ChargeInterest()
		{
			decimal accrual = (decimal)this.Rate * this.Balance;
			this.Balance += accrual;

			Console.WriteLine($"You will get {accrual}$ to addition to you current balance.");
		}

		public void GetMoney()
		{
			Console.WriteLine("How much money would you like to get?");
			string strFunds = Console.ReadLine();
			decimal.TryParse(strFunds, out decimal funds);
			this.Balance -= funds;
			Console.WriteLine($"Here is your {funds}$. Your current balance is {this.Balance}$.");
		}

		public void DepositMoney()
		{
			Console.WriteLine("How much money would you like to deposit?");
			string strPayment = Console.ReadLine();
			decimal.TryParse(strPayment, out decimal payment);
			this.Balance += payment;
			Console.WriteLine($"Your payment is {payment}$. Your current balance is {this.Balance}$.");
		}
	}
}
