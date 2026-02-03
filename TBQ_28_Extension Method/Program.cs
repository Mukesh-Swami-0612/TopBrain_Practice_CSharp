
using System;
using System.Collections.Generic;

public static class StringExtensions
{
    // Custom DistinctBy Extension Method
    public static string[] DistinctById(this string[] items)
    {
        HashSet<string> seenIds = new HashSet<string>();
        List<string> result = new List<string>();

        foreach (string item in items)
        {
            if (string.IsNullOrEmpty(item))
                continue;

            // Split "id:name"
            string[] parts = item.Split(':');

            if (parts.Length != 2)
                continue;

            string id = parts[0];
            string name = parts[1];

            // If ID not seen before
            if (!seenIds.Contains(id))
            {
                seenIds.Add(id);
                result.Add(name);
            }
        }

        return result.ToArray();
    }
}

class Program
{
    static void Main()
    {
        string[] items =
        {
            "1:John",
            "2:Alice",
            "1:Bob",
            "3:Tom",
            "2:David"
        };

        string[] distinctNames = items.DistinctById();

        foreach (string name in distinctNames)
        {
            Console.WriteLine(name);
        }
    }
}
