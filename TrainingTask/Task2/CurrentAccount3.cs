using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2
{
	class CurrentAccount3 : BankAccount, IBalanceAccessible
	{
		public CurrentAccount3(decimal balance, string owner, int accountNumber) 
			: base(balance, owner, accountNumber)
		{

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
