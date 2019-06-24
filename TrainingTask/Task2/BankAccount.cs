using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2
{
	public class BankAccount
	{
		private decimal balance;

		private string owner;

		public int AccountNumber { get; set; }

		public decimal Balance
		{
			get { return balance; }
			set { balance = value; }
		}

		public string Owner
		{
			get { return owner; }
			set { owner = value; }
		}

		public BankAccount (decimal balance, string owner, int accountNumber)
		{
			this.Balance = balance;
			this.Owner = owner;
			this.AccountNumber = accountNumber;
		}

		public decimal GetCurrentBalance()
		{
			return this.Balance;
		}

		public string GetAccountOwner()
		{
			return this.Owner;
		}

		public decimal CloseAccount()
		{
			decimal temp = this.Balance;
			Console.WriteLine($"Account owner gets {temp}$");
			this.Balance = 0.00m;

			return this.Balance;
		}
	}
}
