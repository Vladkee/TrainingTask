using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2
{
	class DepositAccount : BankAccount, IInterestCountable
	{
		public double Rate { get; set; }
		
		public DepositAccount(decimal balance, string owner, int accountNumber) 
			: base(balance, owner, accountNumber)
		{	}

		public double ChooseRate()
		{
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

			Console.WriteLine("Would you like to deposit money on this period? ('y' or 'n')");
			string depositDesicion = Console.ReadLine();
			if (depositDesicion == "y")
			{
				Console.WriteLine("How much money would you like to deposit?");
				string depositMoney = Console.ReadLine();
				decimal.TryParse(depositMoney, out decimal money);
				decimal futureMoney = money * (decimal)this.Rate;

				Console.WriteLine($"Your rate is {this.Rate}. So you will get {futureMoney}$.");
			}
			else if (depositDesicion == "n")
			{
				Console.WriteLine("Operation is over. Good luck.");
			}
			else
			{
				throw new Exception("You chose wrong option. Try again.");
			}
			return this.Rate;
		}

		public void ChargeInterest()
		{
			Random random = new Random();
			decimal intRate = random.Next(1,10);
			decimal decRate = intRate / 100;

			decimal accrual = this.Balance * decRate;
			this.Balance += accrual;

			Console.WriteLine($"You have accumulated {intRate}% per year, would you like to charge them to your account? ('y' or 'n')");
			string rateDesicion = Console.ReadLine();

			if (rateDesicion == "y")
			{
				Console.WriteLine($"You will get {accrual}$ to addition to your current balance.");
			}
			else if (rateDesicion == "n")
			{
				Console.WriteLine("Ok. Your rate will be higher next month.");
			}
			else
			{
				throw new Exception("Wrong option. Try again!");
			}
		}
	}
}
