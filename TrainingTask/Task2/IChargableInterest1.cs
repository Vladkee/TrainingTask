using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2
{
	interface IChargableInterest1
	{
		decimal Interest { get; set; }

		void ChargeInterest();
	}
}
