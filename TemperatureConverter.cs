using System;

namespace Assignment2
{
	public class TemperatureConverter
	{
		public void StartConversion()
		{
			while (true)
			{
				Console.Clear();
				ConsoleFormatter.PrintHeader("TEMPERATURE CONVERTER");
				ConsoleFormatter.PrintMenuItem("Fahrenheit to Celsius", "1");
				ConsoleFormatter.PrintMenuItem("Celsius to Fahrenheit", "2");
				ConsoleFormatter.PrintMenuItem("Return to Main Menu", "0");

				Console.Write("\nEnter your choice: ");

				if (!int.TryParse(Console.ReadLine(), out int choice))
				{
					Console.WriteLine("Invalid input. Please enter a number.");
				}
				else
				{

					switch (choice)
					{
						case 1:
							ConvertFahrenheitToCelsius();
							break;
						case 2:
							ConvertCelsiusToFahrenheit();
							break;
						case 0:
							Console.WriteLine("Returning to Main Menu...");
							return;
						default:
							Console.WriteLine("Invalid choice.");
							break;
					}

					if (choice != 0)
					{
						Console.WriteLine("\nPress any key to return to the Temperature Converter menu...");
						Console.ReadKey();
					}
				}
			}
		}

		public void ConvertFahrenheitToCelsius()
		{
			for (int f = 0; f <= 212; f += 10)
			{
				double c = 5.0 / 9.0 * (f - 32);
				Console.WriteLine($"{f} F = {c:F2} C");
			}
		}

		public void ConvertCelsiusToFahrenheit()
		{
			for (int c = 0; c <= 100; c += 5)
			{
				double f = 9.0 / 5.0 * c + 32;
				Console.WriteLine($"{c} C = {f:F2} F");
			}
		}
	}
}

