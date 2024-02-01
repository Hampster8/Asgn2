using System;

namespace Assignment2
{
	public class ConsoleMenu
	{
		public void Run()
		{
			while (true)
			{
				Console.Clear();
				DisplayMainMenu();

				if (!int.TryParse(Console.ReadLine(), out int choice))
				{
					HandleInvalidInput();
					continue;
				}

				if (choice == 0)
				{
					Console.WriteLine("Exiting the program. Goodbye!");
					break;
				}

				HandleMenuSelection(choice);

				Console.WriteLine("\nOperation completed. Press any key to return to the main menu...");
				Console.ReadKey();
			}
		}

		private void HandleInvalidInput()
		{
			Console.WriteLine("Please enter a valid number.");
			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
		}

		private void DisplayMainMenu()
		{
			ConsoleFormatter.PrintHeader("MAIN MENU");
			ConsoleFormatter.PrintMenuItem("Temperature Converter", "1");
			ConsoleFormatter.PrintMenuItem("String Functions", "2");
			ConsoleFormatter.PrintMenuItem("Math Work", "3");
			ConsoleFormatter.PrintMenuItem("Scheduler", "4");
			ConsoleFormatter.PrintMenuItem("Exit", "0");
			Console.Write("\nEnter your choice: ");
		}

		private void HandleMenuSelection(int choice)
		{
			switch (choice)
			{
				case 1:
					new TemperatureConverter().StartConversion();
					break;
				case 2:
					new StringFunctions().StartStringFunctions();
					break;
				case 3:
					new MathWork().Calculate();
					break;
				case 4:
					new Scheduler().DisplaySchedule();
					break;
				default:
					Console.WriteLine("Invalid choice.");
					break;
			}
		}
	}
}
