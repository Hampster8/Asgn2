using System;

namespace Assignment2
{

	public class StringFunctions
	{

		public void StartStringFunctions()
		{
			Console.Clear();
			ConsoleFormatter.PrintHeader("++++++++++++ STRING FUNCTIONS! ++++++++++++");
			ConsoleFormatter.PrintMenuItem("String Length and Uppercase", "1");
			ConsoleFormatter.PrintMenuItem("Predict My Day", "2");
			Console.Write("Enter your choice: ");
			int choice = Convert.ToInt32(Console.ReadLine());

			switch (choice)
			{
				case 1:
					StringLength();
					break;
				case 2:
					PredictMyDay();
					break;
				default:
					Console.WriteLine("Invalid choice.");
					break;
			}
		}

		public void StringLength()
		{
			Console.WriteLine(@"
			Write a text with any number of characters and press Enter.
			You can even copy a text from a file and paste it ");
			Console.WriteLine();
			string text = Console.ReadLine() ?? string.Empty; // Handle null
			int length = text.Length;
			Console.WriteLine($"Uppercase: {text.ToUpper()}");
			Console.WriteLine($"Number of chars: {length}");
		}


		public void PredictMyDay()
		{
			Console.WriteLine(@"
			************ The Fortune Teller ************);
			Let me predict your day! Select a number between 1 and 7:");
			int dayNumber = Convert.ToInt32(Console.ReadLine());

			switch (dayNumber)
			{
				case 1:
					Console.WriteLine("Keep calm on Mondays! You can fall apart!");
					break;
				case 2:
					Console.WriteLine("Tuesdays and Wednesdays break your heart!");
					break;
				case 3:
					Console.WriteLine("Thursday is your lucky day, don't wait for Friday!");
					break;
				case 4:
					Console.WriteLine("Friday, you are in love!");
					break;
				case 5:
					Console.WriteLine("Saturday, do nothing and do plenty of it!");
					break;
				case 6:
					Console.WriteLine("And Sunday always comes too soon!");
					break;
				case 7:
					Console.WriteLine("No day? A good day but it doesn't exist!");
					break;
				default:
					Console.WriteLine("Error: Please select a number between 1 and 7.");
					AskToRunAgain();
					break;
			}
		}

		public bool AskToRunAgain()
		{
			Console.Write("Continue with another round? (y/n): ");
			string answer = Console.ReadLine().ToLower();
			return answer == "y";
		}
	}
}
