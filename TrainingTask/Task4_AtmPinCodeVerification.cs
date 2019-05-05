using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
	class Task4_AtmPinCodeVerification
	{
		public static void Execute()
		{
			string strPinCode = GetPinCode();
			int pinCode = ValidatePIN(strPinCode);
			DisplayResult();
		}

		private static string GetPinCode()
		{
			Console.WriteLine("Enter a PIN code");
			var strPinCode = Console.ReadLine();
			return strPinCode;
		}

		private static int ValidatePIN(string strPinCode)
		{
			int pinCode = 0;
			if (Int32.TryParse(strPinCode, out pinCode) && strPinCode.Length == 4 || strPinCode.Length == 6 && pinCode > 0)
			{
				return pinCode;
			}
			else
			{
				throw new ArgumentException("You've entered an incorrect PIN code. Enter 4-didit or 6-digit PIN code!");
				
			}
		}

		private static void DisplayResult()
		{
			Console.WriteLine("Correct PIN code.");
		}
	}
}
