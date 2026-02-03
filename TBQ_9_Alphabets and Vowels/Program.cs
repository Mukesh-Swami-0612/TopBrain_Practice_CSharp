using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();

        HashSet<char> set = new HashSet<char>();

        foreach (char ch in word2.ToLower())
        {
            set.Add(ch);
        }

        StringBuilder filtered = new StringBuilder();

        foreach (char ch in word1)
        {
            char lower = char.ToLower(ch);

            bool isVowel = IsVowel(lower);

            if (!isVowel && set.Contains(lower))
            {
                continue;
            }

            filtered.Append(ch);
        }

        StringBuilder result = new StringBuilder();

        if (filtered.Length > 0)
        {
            result.Append(filtered[0]);

            for (int i = 1; i < filtered.Length; i++)
            {
                if (filtered[i] != filtered[i - 1])
                {
                    result.Append(filtered[i]);
                }
            }
        }

        Console.WriteLine(result.ToString());
    }

    static bool IsVowel(char ch)
    {
        return ch == 'a' || ch == 'e' || ch == 'i' ||
               ch == 'o' || ch == 'u';
    }
}
