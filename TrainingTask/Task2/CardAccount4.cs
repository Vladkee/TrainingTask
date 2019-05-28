using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2
{
	class CardAccount4 : IChargableInterest1, IOperableAccount2
	{
		public decimal Interest { get; set; }
		public void ChargeInterest()
		{
			throw new NotImplementedException();
		}

		public void GetMoney(decimal funds)
		{
			throw new NotImplementedException();
		}

		public void DepositMoney(decimal payment)
		{
			throw new NotImplementedException();
		}
	}
}
