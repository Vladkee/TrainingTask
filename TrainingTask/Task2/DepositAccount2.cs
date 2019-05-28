using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2
{
	class DepositAccount2 : IChargableInterest1
	{
		public decimal Interest { get; set; }
		public void ChargeInterest()
		{
			throw new NotImplementedException();
		}
	}
}
