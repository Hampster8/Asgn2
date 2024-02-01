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
			for (int fahrenheit = 0; fahrenheit <= 212; fahrenheit += 10)
			{
				// Formula to convert Fahrenheit to Celsius: C = (F - 32) * 5/9
				double celsius = 5.0 / 9.0 * (fahrenheit - 32);
				Console.WriteLine($"{fahrenheit} F = {celsius:F2} C");
			}
		}

		public void ConvertCelsiusToFahrenheit()
		{
			for (int celsius = 0; celsius <= 100; celsius += 5)
			{
				// Formula to convert Celsius to Fahrenheit: F = C * 9/5 + 32
				double fahrenheit = 9.0 / 5.0 * celsius + 32;
				Console.WriteLine($"{celsius} C = {fahrenheit:F2} F");
			}
		}
	}
}

