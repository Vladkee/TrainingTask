using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2
{
	interface IOperableAccount2
	{
		void DepositMoney(decimal payment);

		void GetMoney(decimal funds);
	}
}
