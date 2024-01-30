namespace Assignment2
{
	public static class ConsoleFormatter
	{
		public const int maxWidth = 32;
		public static void PrintHeader(string title)
		{
			string border = new string('*', ConsoleFormatter.maxWidth);
			Console.WriteLine(border);
			Console.WriteLine(ConsoleFormatter.CenterText(title));
			Console.WriteLine(border);
		}


		public static string CenterText(string text)
		{
			if (text.Length >= maxWidth)
			{
				return text; // Return the text as is if it's too long
			}

			int spaces = (maxWidth - text.Length) / 2;
			return new string(' ', spaces) + text;
		}
		public static void PrintMenuItem(string text, string option)
		{
			string menuItem = $"{text.PadRight(maxWidth, ' ')} : {option}";
			Console.WriteLine(ConsoleFormatter.CenterText(menuItem));
		}

	}

}
