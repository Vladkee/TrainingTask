using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task1
{
	public class TrainScheduler
	{
		private const int TrainMaxNumber = 2;

		private Train[] trainList;

		public TrainScheduler()
		{
			this.trainList = new Train[TrainScheduler.TrainMaxNumber];
		}

		public void Execute()
		{
			for (int i = 0; i < TrainScheduler.TrainMaxNumber; i++)
				this.trainList[i] = this.GetNewTrain();

			int selectedTrainNumber = this.AskTrainNumber();

			this.DisplayTrainInfo(selectedTrainNumber);
		}

		private int AskTrainNumber()
		{
			int trainNumber;
			while (true)
			{
				Console.WriteLine("Enter the number of the train");
				if (Int32.TryParse(Console.ReadLine(), out trainNumber))
					break;
			}
			return trainNumber;
		}

		private void DisplayTrainInfo(int trainNumber)
		{
			Train selectedTrain = new Train();
			for (int i = 0; i < TrainScheduler.TrainMaxNumber; i++)
			{
				if (this.trainList[i].GetTrainNumber() == trainNumber)
					selectedTrain = this.trainList[i];
			}

			if (selectedTrain.GetTrainNumber() == 0)
			{
				Console.WriteLine($"Train number {trainNumber} was not found on the list of trains.");
				return;
			}
			Console.WriteLine($"Train {trainNumber} is departuring to {selectedTrain.GetDestination()} at {selectedTrain.GetDepartureTime()}");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		private Train GetNewTrain()
		{
			int trainNumber = 0;
			while (true)
			{
				Console.WriteLine("Enter the number of the train");
				if (Int32.TryParse(Console.ReadLine(), out trainNumber))
					break;
			}
			DateTime departureTime;
			while (true)
			{
				Console.WriteLine("Enter departure time");
				if (DateTime.TryParse(Console.ReadLine(), out departureTime))
					break;
			}
			string destination = string.Empty;
			while (true)
			{
				Console.WriteLine("Enter destination of the train");

				destination = Console.ReadLine();
				if (!string.IsNullOrWhiteSpace(destination))
					break;
			}

			return new Train(trainNumber, destination, departureTime);
		}
	}
}
