using System;
using System.Text;

namespace Assignment2
{
	public class MathWork
	{
		public void Calculate()
		{
			while (true)
			{
				Console.Clear();
				ConsoleFormatter.PrintHeader("++++++++++++ Math Works! ++++++++++++");
				int start, end;
				Console.Write("Enter the starting number: ");
				while (!int.TryParse(Console.ReadLine(), out start))
				{
					Console.WriteLine("Invalid input. Please enter a valid integer for the starting number.");
					Console.Write("Enter the starting number: ");
				}

				Console.Write("Enter the ending number: ");
				while (!int.TryParse(Console.ReadLine(), out end))
				{
					Console.WriteLine("Invalid input. Please enter a valid integer for the ending number.");
					Console.Write("Enter the ending number: ");
				}

				Console.WriteLine($"The sum of numbers between {start} and {end} is: {SumOfNumbers(start, end)}");
				Console.WriteLine(PrintEvenNumbers(start, end));
				Console.WriteLine(PrintOddNumbers(start, end));
				Console.WriteLine(CalculateSquareRoots(start, end));
				PrintMultiplicationTable();

				if (!ExitCalculation())
				{
					break;
				}
			}
		}

		public int SumOfNumbers(int start, int end)
		{
			int sum = 0;
			int lower = Math.Min(start, end);
			int upper = Math.Max(start, end);
			for (int number = lower; number <= upper; number++)
			{
				sum += number;
			}
			return sum;
		}

		public string PrintEvenNumbers(int start, int end)
		{
			StringBuilder evenNumbers = new StringBuilder();
			int lower = Math.Min(start, end);
			int upper = Math.Max(start, end);
			evenNumbers.Append($"Even numbers between {lower} and {upper}: ");
			for (int number = lower; number <= upper; number++)
			{
				if (number % 2 == 0)
				{
					evenNumbers.Append(number + " ");
				}
			}
			return evenNumbers.ToString();
		}

		public string PrintOddNumbers(int start, int end)
		{
			StringBuilder oddNumbers = new StringBuilder();
			int lower = Math.Min(start, end);
			int upper = Math.Max(start, end);
			oddNumbers.Append($"Odd numbers between {lower} and {upper}: ");
			for (int i = lower; i <= upper; i++)
			{
				if (i % 2 != 0)
				{
					oddNumbers.Append(i + " ");
				}
			}
			return oddNumbers.ToString();
		}

		public string CalculateSquareRoots(int start, int end)
		{
			StringBuilder squareRoots = new StringBuilder();
			int lower = Math.Min(start, end);
			int upper = Math.Max(start, end);
			squareRoots.Append($"Square roots between {lower} and {upper}: \n");
			for (int number = lower; number <= upper; number++)
			{
				squareRoots.AppendLine($"Square root of {number} = {Math.Sqrt(number):F2}");
			}
			return squareRoots.ToString();
		}

		public void PrintMultiplicationTable()
		{
			Console.WriteLine("Multiplication Table (1 to 10):");
			for (int multiplier = 1; multiplier <= 10; multiplier++)
			{
				for (int multiplicand = 1; multiplicand <= 10; multiplicand++)
				{
					Console.Write($"{multiplier * multiplicand}\t");
				}
				Console.WriteLine();
			}
		}

		public bool ExitCalculation()
		{
			Console.Write("Do you want to exit? (yes/no): ");
			string response = Console.ReadLine().ToLower();
			return response == "yes";
		}
	}
}
