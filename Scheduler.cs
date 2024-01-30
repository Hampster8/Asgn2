using System;
using System.Collections.Generic;
namespace Assignment2
{

	public class Scheduler
	{
		public void DisplaySchedule()
		{
			while (true)
			{
				Console.Clear();
				ConsoleFormatter.PrintHeader("SCHEDULER");
				ConsoleFormatter.PrintMenuItem("Weekend Schedule", "1");
				ConsoleFormatter.PrintMenuItem("Night Shift Schedule", "2");
				ConsoleFormatter.PrintMenuItem("Exit", "0");
				Console.Write("Choose an option: ");

				if (!int.TryParse(Console.ReadLine(), out int choice))
				{
					Console.WriteLine("Invalid input. Please enter a valid number.");
					continue;
				}

				if (choice == 0) break;

				int startWeek, interval;
				if (choice == 1)
				{
					startWeek = 2; // Every other weekend starting from week 2
					interval = 2;
					Console.WriteLine("Weekend Schedule:");
				}
				else if (choice == 2)
				{
					startWeek = 1; // Night shift every 4th week starting from week 1
					interval = 4;
					Console.WriteLine("Night Shift Schedule:");
				}
				else
				{
					Console.WriteLine("Invalid choice.");
					continue;
				}

				List<int> schedule = CalculateSchedule(startWeek, interval);
				PrintScheduleInColumns(schedule, 7);


				Console.WriteLine("\nPress any key to return to the main menu...");
				Console.ReadKey();
			}
		}

		private void PrintScheduleInColumns(List<int> schedule, int maxRows)
		{
			int columnCount = 0;
			foreach (int week in schedule)
			{
				Console.Write($"Week {week}\t\t");
				columnCount++;

				if (columnCount >= maxRows)
				{
					Console.WriteLine();
					columnCount = 0;
				}
			}
		}

		private List<int> CalculateSchedule(int startWeek, int interval)
		{
			List<int> schedule = new List<int>();
			for (int week = startWeek; week <= 52; week += interval)
			{
				schedule.Add(week);
			}
			return schedule;
		}
	}
}