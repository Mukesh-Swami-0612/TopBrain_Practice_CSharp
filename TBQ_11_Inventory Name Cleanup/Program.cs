using System;
using System.Globalization;
using System.Text;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        // Trim and remove extra spaces
        string[] parts = input.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string cleaned = string.Join(" ", parts);

        // Remove consecutive duplicate characters
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < cleaned.Length; i++)
        {
            if (i == 0 || cleaned[i] != cleaned[i - 1])
                sb.Append(cleaned[i]);
        }

        // Convert to TitleCase
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string result = textInfo.ToTitleCase(sb.ToString().ToLower());

        Console.WriteLine(result);
    }
}
