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

				if (start > end)
				{
					Console.WriteLine("The starting number must be less than or equal to the ending number.");
					continue;
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
			for (int i = start; i <= end; i++)
			{
				sum += i;
			}
			return sum;
		}

		public string PrintEvenNumbers(int start, int end)
		{
			StringBuilder evenNumbers = new StringBuilder();
			evenNumbers.Append($"Even numbers between {start} and {end}: ");
			for (int i = start; i <= end; i++)
			{
				if (i % 2 == 0)
				{
					evenNumbers.Append(i + " ");
				}
			}
			return evenNumbers.ToString();
		}

		public string PrintOddNumbers(int start, int end)
		{
			StringBuilder oddNumbers = new StringBuilder();
			oddNumbers.Append($"Odd numbers between {start} and {end}: ");
			for (int i = start; i <= end; i++)
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
			squareRoots.Append($"Square roots between {start} and {end}: \n");
			for (int i = start; i <= end; i++)
			{
				squareRoots.AppendLine($"Square root of {i} = {Math.Sqrt(i):F2}");
			}
			return squareRoots.ToString();
		}

		public void PrintMultiplicationTable()
		{
			Console.WriteLine("Multiplication Table (1 to 10):");
			for (int i = 1; i <= 10; i++)
			{
				for (int j = 1; j <= 10; j++)
				{
					Console.Write($"{i * j}\t");
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
