using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static bool IsVowel(char c)
    {
        c = char.ToLower(c);
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }

    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        // Store consonants from second word (case-insensitive)
        HashSet<char> consonantsInSecond = new HashSet<char>();
        foreach (char ch in second)
        {
            char c = char.ToLower(ch);
            if (!IsVowel(c)) consonantsInSecond.Add(c);
        }

        // Task 1: Remove consonants from first that appear in second
        StringBuilder filtered = new StringBuilder();
        foreach (char ch in first)
        {
            char c = char.ToLower(ch);

            if (!IsVowel(c) && consonantsInSecond.Contains(c))
                continue; // remove common consonant

            filtered.Append(ch); // keep
        }

        // Task 2: Remove consecutive duplicates (case-insensitive)
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < filtered.Length; i++)
        {
            if (i == 0)
            {
                result.Append(filtered[i]);
            }
            else
            {
                char prev = char.ToLower(result[result.Length - 1]);
                char curr = char.ToLower(filtered[i]);

                if (prev != curr)
                    result.Append(filtered[i]);
            }
        }

        Console.WriteLine(result.ToString());
    }
}
