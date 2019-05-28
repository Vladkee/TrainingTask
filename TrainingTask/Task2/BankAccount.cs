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

		public BankAccount (decimal balance, string owner)
		{
			this.balance = balance;
			this.owner = owner;
		}

		public decimal GetCurrentBalance()
		{
			return this.balance;
		}

		public string GetAccountOwner()
		{
			return this.owner;
		}

		public decimal CloseAccount()
		{
			decimal temp = this.balance;
			Console.WriteLine($"Account owner gets {temp}$");
			this.balance = 0.00m;

			return this.balance;
		}
	}
}
